﻿using Abp.Application.Editions;
using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;

namespace LVY.Backend.Editions;

public class EditionManager : AbpEditionManager
{
    public const string DefaultEditionName = "Standard";

    public EditionManager(
        IRepository<Edition> editionRepository,
        IAbpZeroFeatureValueStore featureValueStore,
        IUnitOfWorkManager unitOfWorkManager)
        : base(editionRepository, featureValueStore, unitOfWorkManager)
    {
    }
}
