using System.Text.Json;
using static System.Console;



int x = 2;
int y = 3;
int w = 5;
int h = 1;



var json = $$"""
    {
        "rectangles": [
            {
                "x": {{x}},
                "y": {{y}},
                "width": {{w}},
                "height": {{h}}
            },
            {
                "x": {{x}},
                "y": {{y}},
                "width": {{w}},
                "height": {{h}}
            }
        ]
    }
    """;

var obj = JsonSerializer.Deserialize<Root>(json);

WriteLine(json);


class Root
{
    public List<Rectangle> Rectangles { get; set; }
};

class Rectangle
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
}