using Microsoft.Playwright;

namespace PlaywrightTests.PageObjects;


public class TextInputPage
{
    private readonly IPage _page;
    private readonly string _url = "http://www.uitestingplayground.com/textinput";
    public ILocator Input => _page.Locator("input#newButtonName");
    public ILocator Button => _page.Locator("button#updatingButton");

    public TextInputPage(IPage page)
    {
        _page = page;
    }
    public async Task NavigateAsync()
    {
        await _page.GotoAsync(_url);
    }
    public async Task EnterTextAsync(string buttonName)
    {
        await Input.FillAsync(buttonName);
        await Button.ClickAsync();
    }
    public async Task ClickbuttonAsync()
    {
        await Button.ClickAsync();
    }
    public async Task GetButtonTextAsync()
    {
        await Button.InnerTextAsync();
    }
}
