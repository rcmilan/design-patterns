namespace Composite.Components
{
    /// <summary>
    /// <para><b>Interface do composite</b></para>
    /// <para>Declara as operações comuns</para>
    /// </summary>
    public interface IProduct
    {
        decimal GetPrice();

        string GetBrand();
    }
}
