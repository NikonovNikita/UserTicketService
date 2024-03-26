namespace UserTicketService.Tests;

public class TicketServiceTests
{
    [Test]
    public void GetTicketPriceMustReturnExistingPrice()
    {
        var ticketServiceTest = new TicketService();
        Assert.IsNotNull(ticketServiceTest.GetTicketPrice(3));
    }

    [Test]
    public void GetTicketPriceMustThrowException()
    {
        var ticketServiceTest = new TicketService();
        Assert.Throws<TicketNotFoundException>(() => ticketServiceTest.GetTicketPrice(4));
    }
}
