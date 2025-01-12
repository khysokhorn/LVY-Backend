import { LVY-BackendTemplatePage } from './app.po';

describe('LVY-Backend App', function() {
  let page: LVY-BackendTemplatePage;

  beforeEach(() => {
    page = new LVY-BackendTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
