using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TruPulseManager
{
    class SharpMath
    {
        // Store our knot values
        public List<int> knotValues = new List<int>();

        // Track the degree to draw our spline with
        public int degree = 5;

        // Resets the knot values to the default knot values
        // for a specified S.
        public void SetDefaultKnots(int S)
        {
            // Clear old ones
            knotValues.Clear();

            int N = S + degree + 1;
            for (int i = 0; i <= N; ++i)
            {
                // Knot values just increment by 1 till we have
                // enough.
                knotValues.Add(i);
            }
        }

        // Makes sure the knot values are valid for a specified S,
        // attempts to fix them if they are incorrect. Returns
        // true if the knots had to be fixed.
        public bool ValidateKnots(int S)
        {
            // If we don't have any knot values
            if (knotValues.Count < 1)
            {
                // Just set default knots and get out of here
                SetDefaultKnots(S);
                return true;
            }

            // Get the last knot value
            int lastValue = knotValues[knotValues.Count - 1];

            // Store whether our knots were valid
            bool val = false;

            // Add more knot values onto the end if necessary
            int N = S + degree + 1;
            for (int i = knotValues.Count + 1; i <= N; ++i)
            {
                knotValues.Add(++lastValue);

                // Track that we had to append knot values
                val = true;
            }

            // Let the user know whether the knot values were valid.
            return val;
        }


        // Performs the Deboor algorithm on a list of control points, filling in the shells as well if shells are enabled.
        public List<Vector> GetDeboor(List<Vector> controlPoints, List<List<Vector>> shells, float shellValue, bool drawShells)
        {
            int S = controlPoints.Count - 1;
            int N = S + degree + 1;

            // List of result points
            List<Vector> result = new List<Vector>();

            // Make sure we have enough control points to draw with this degree, if not
            // just quit.
            if (controlPoints.Count <= degree)
                return result;

            // Iterate over the entire spline. We multiply everything by 100 so that we don't do
            // repeated addition on a float, using an int instead.
            for (int tP = knotValues[degree] * 100; tP < knotValues[N - degree] * 100; ++tP)
            {
                // Convert back into real value
                float T = tP / 100.0f;

                int J = 0;
                // Find J.
                for (int i = 1; i < knotValues.Count; ++i)
                {
                    if (knotValues[i] > T)
                    {
                        J = i - 1;
                        break;
                    }
                }

                // Start the recursive aspect of the deboor algorithm and add the resulting point to the
                // final points list.
                result.Add(DeboorStage(T, degree, J, controlPoints, shells, (drawShells && shellValue == tP)));
            }

            // Return the list of rasterized points.
            return result;
        }

        // Performs one stage of the recursive part of the deboor algorithm.
        public Vector DeboorStage(float T, int P, int I, List<Vector> controlPoints, List<List<Vector>> shells, bool drawShells)
        {
            // P == 0 is the base case, so just return the value of the proper
            // control point.
            if (P == 0)
            {
                return controlPoints[I];
            }

            // Recursively peform the deboor stage
            Vector point1 = DeboorStage(T, P - 1, I, controlPoints, shells, drawShells);
            Vector point2 = DeboorStage(T, P - 1, I - 1, controlPoints, shells, drawShells);

            // If we're drawing shells, add these points to our list of shell points
            if (drawShells)
            {
                List<Vector> sh = new List<Vector>();
                sh.Add(point1);
                sh.Add(point2);
                shells.Add(sh);
            }

            int tI = knotValues[I];
            int tID = knotValues[I + degree - (P - 1)];

            // Calculate point X and point Y using doubles
            // for a bit of added accuracy
            double PX = (point1.X * ((T - tI) / (tID - tI))) + (point2.X * ((tID - T) / (tID - tI)));
            double PY = (point1.Y * ((T - tI) / (tID - tI))) + (point2.Y * ((tID - T) / (tID - tI)));
            double PZ = (point1.Z * ((T - tI) / (tID - tI))) + (point2.Z * ((tID - T) / (tID - tI)));

            // Return it
            return new Vector(PX, PY, PZ);
        }





        private void CalcCurve(Vector[] pts, double tenstion, out Vector p1, out Vector p2)
        {
            double deltaX, deltaY, deltaZ;

            deltaX = pts[2].X - pts[0].X;
            deltaY = pts[2].Y - pts[0].Y;
            deltaZ = pts[2].Z - pts[0].Z;

            p1 = new Vector((pts[1].X - tenstion * deltaX), (pts[1].Y - tenstion * deltaY), (pts[1].Z - tenstion * deltaZ));
            p2 = new Vector((pts[1].X + tenstion * deltaX), (pts[1].Y + tenstion * deltaY), (pts[1].Z + tenstion * deltaZ));
        }

        private void CalcCurveEnd(Vector end, Vector adj, double tension, out Vector p1)
        {
            p1 = new Vector(((tension * (adj.X - end.X) + end.X)), ((tension * (adj.Y - end.Y) + end.Y)), ((tension * (adj.Z - end.Z) + end.Z)));
        }



        public Vector[] cardinalSpline(List<Vector> pts, double t, bool closed)
        {
            int i, nrRetPts;
            Vector p1, p2;
            double tension = t * (1d / 3d); //we are calculating contolpoints.

            if (closed)
                nrRetPts = (pts.Count + 1) * 3 - 2;
            else
                nrRetPts = pts.Count * 3 - 2;

            Vector[] retPnt = new Vector[nrRetPts];
            for (i = 0; i < nrRetPts; i++)
                retPnt[i] = new Vector();

            if (!closed)
            {
                CalcCurveEnd(pts[0], pts[1], tension, out p1);
                retPnt[0] = pts[0];
                retPnt[1] = p1;
            }
            for (i = 0; i < pts.Count - (closed ? 1 : 2); i++)
            {
                CalcCurve(new Vector[] { pts[i], pts[i + 1], pts[(i + 2) % pts.Count] }, tension, out  p1, out p2);
                retPnt[3 * i + 2] = p1;
                retPnt[3 * i + 3] = pts[i + 1];
                retPnt[3 * i + 4] = p2;
            }
            if (closed)
            {
                CalcCurve(new Vector[] { pts[pts.Count - 1], pts[0], pts[1] }, tension, out p1, out p2);
                retPnt[nrRetPts - 2] = p1;
                retPnt[0] = pts[0];
                retPnt[1] = p2;
                retPnt[nrRetPts - 1] = retPnt[0];
            }
            else
            {
                CalcCurveEnd(pts[pts.Count - 1], pts[pts.Count - 2], tension, out p1);
                retPnt[nrRetPts - 2] = p1;
                retPnt[nrRetPts - 1] = pts[pts.Count - 1];
            }
            return retPnt;
        }





        // Gets the list of curve points based on a supplied list of control points and our
        // current spline matrix.
        public List<Vector> GetSplinePoints(List<Vector> controlPoints)
        {
            // Store result points
            List<Vector> splinePoints = new List<Vector>();





            // Return all of our result points.
            return splinePoints;
        }
    }
}
