import { BackendTemplatePage } from './app.po';

describe('Backend App', function() {
  let page: BackendTemplatePage;

  beforeEach(() => {
    page = new BackendTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
