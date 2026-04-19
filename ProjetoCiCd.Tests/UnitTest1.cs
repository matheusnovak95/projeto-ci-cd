using Xunit;

public class TesteSimples
{
    [Fact]
    public void TesteBasico()
    {
        Assert.True(1 + 1 == 2);
    }
}