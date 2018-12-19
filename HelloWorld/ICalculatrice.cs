namespace HelloWorld
{
    interface ICalculatrice
    {
        void Add(float f);
        void Substract(float f);
        void Multiply(float f);
        void Divide(float f);
        float GetCurrentValue();
        void Reset();
    }
}
