
namespace LibraryForToast {

    public class GetAreaShape {
        public float DefineShape(params float[] param) {
            Figure figure;
            float s = 0;

            if (param.Length == 1) {
                figure = new Circle();
                s = figure.GetArea(param);
            }
            if (param.Length == 3) {
                figure = new Triangle();
                s = figure.GetArea(param);
            }
            
            return s;
        }
    }


    internal abstract class Figure {
        internal abstract float GetArea(params float[] parameters);
    }

    internal class Circle : Figure {
        internal override float GetArea(params float[] parameters) => calculateArea(parameters[0]);

        private float calculateArea(float radius) => MathF.Pow(radius, 2) * MathF.PI;
    }

    internal class Triangle : Figure {
        internal override float GetArea(params float[] parameters) => calculateArea(parameters[0], parameters[1], parameters[2]);

        private float calculateArea(float boardA, float boardB, float boardC) {
            float p = (boardA + boardB + boardC) / 2;
            float s = MathF.Sqrt(p * (p - boardA) * (p - boardB) * (p - boardC));

            return s;
        }
    }
}