using System;

namespace oopPracticle;

public interface Shape
{
    void draw();
}

interface ICircle
{
    int HasRadious(int r);
}

class DrawShape : ICircle
{
    public int HasRadious(int r)
    {
        return r;
    }
}