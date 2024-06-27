using System.Drawing;
using System.Reflection;

namespace ConsoleApp3;

public class Color
{
    public int Red { get;  set; }
    public int Green { get;  set; }
    public int Blue { get;  set; }
    public int Alpha { get; set; }


    public Color(int red, int green, int blue, int alpha = 255)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;
    }

    public int GreyScaleV()
    {
        return (Red + Green + Blue) / 3;
    }
}

public class Ball
{
    public int Size { get; set; }
    public Color Color { get; set; }
    public int thrown { get; set; }

    public Ball(int size , Color color)
    {
        Size = size;
        Color = color;
        thrown = 0;
    }

    public void Pop()
    {
        Size = 0;
    }

    public int ThrowCount()
    {
        if (Size !=  0)
        {
            thrown++;
        }

        return thrown;
    }
}