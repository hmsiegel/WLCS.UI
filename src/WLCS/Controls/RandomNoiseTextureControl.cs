namespace WLCS.Controls;
public sealed class RandomNoiseTextureControl : Control
{
    private const int _desiredWidth = 300;
    private const int _desiredHeight = 300;
    private static RenderTargetBitmap? _texture;

    private static readonly Random _rng = new();

    public RandomNoiseTextureControl()
    {
        if (_texture is not { })
        {
            GenerateNoise();
        }
    }

    protected override Size MeasureOverride(Size availableSize)
    {
        return new Size(_desiredWidth, _desiredHeight);
    }

    public override void Render(DrawingContext context)
    {
        if (_texture is not { })
        {
            return;
        }

        context.DrawImage(_texture, new Rect(0, 0, _desiredWidth, _desiredHeight));
        base.Render(context);
    }

    private static void GenerateNoise()
    {
        _texture = new RenderTargetBitmap(new PixelSize(_desiredWidth, _desiredHeight));

        using var dc = _texture.CreateDrawingContext();

        for (var i = 0; i < _desiredHeight; i++)
        {
            for (var j = 0; j < _desiredWidth; j++)
            {
                var k = new RoundedRect(new Rect(i, j, 1, 1));
                var c = _rng.NextDouble() > 0.5 ? Brushes.White : Brushes.Black;
                dc.DrawRectangle(c, null, k);
            }
        }
    }
}
