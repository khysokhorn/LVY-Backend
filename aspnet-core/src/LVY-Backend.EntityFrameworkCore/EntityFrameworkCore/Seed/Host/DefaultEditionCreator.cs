using Abp.Application.Editions;
using Abp.Application.Features;
using LVY-Backend.Editions;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LVY-Backend.EntityFrameworkCore.Seed.Host;

public class DefaultEditionCreator
{
    private readonly LVY-BackendDbContext _context;

    public DefaultEditionCreator(LVY-BackendDbContext context)
    {
        _context = context;
    }

    public void Create()
    {
        CreateEditions();
    }

    private void CreateEditions()
    {
        var defaultEdition = _context.Editions.IgnoreQueryFilters().FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
        if (defaultEdition == null)
        {
            defaultEdition = new Edition { Name = EditionManager.DefaultEditionName, DisplayName = EditionManager.DefaultEditionName };
            _context.Editions.Add(defaultEdition);
            _context.SaveChanges();

            /* Add desired features to the standard edition, if wanted... */
        }
    }

    private void CreateFeatureIfNotExists(int editionId, string featureName, bool isEnabled)
    {
        if (_context.EditionFeatureSettings.IgnoreQueryFilters().Any(ef => ef.EditionId == editionId && ef.Name == featureName))
        {
            return;
        }

        _context.EditionFeatureSettings.Add(new EditionFeatureSetting
        {
            Name = featureName,
            Value = isEnabled.ToString(),
            EditionId = editionId
        });
        _context.SaveChanges();
    }
}