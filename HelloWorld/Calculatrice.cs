namespace HelloWorld
{
    class Calculatrice : ICalculatrice
    {
        private float f = 0;

        public void Add(float f)
        {
            this.f = GetCurrentValue() + f;
        }

        public void Divide(float f)
        {
            this.f = GetCurrentValue() / f;
        }

        public float GetCurrentValue()
        {
            return f;
        }

        public void Multiply(float f)
        {
            this.f = GetCurrentValue() * f;
        }

        public void Reset()
        {
            f = 0;
        }

        public void Substract(float f)
        {
            this.f = GetCurrentValue() - f;
        }
    }
}
