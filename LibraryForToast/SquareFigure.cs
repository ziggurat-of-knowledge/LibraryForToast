using System;
using System.Runtime.InteropServices;

namespace LibraryForToast {

    public class SquareFigure {
        private GetAreaShape getArea;
        public SquareFigure() {
            getArea = new GetAreaShape();
        }

        public float GetArea(params float[] parameters) => getArea.DefineShape(parameters);

        public string IsTriangleRectangular(float a, float b, float c) {
            float[] param = new float[3] { a, b, c };

            HashSet<float> result = new HashSet<float>(param);
            if (result.Count == 2) { return "the triangle is isosceles"; }

            return "you have a strange triangle";
        }
    }
}