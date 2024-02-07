public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }
    public string Getcolor()
    {
        return _color;
    }
    public void Setcolor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();

}