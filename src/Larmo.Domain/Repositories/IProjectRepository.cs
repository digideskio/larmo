﻿using Larmo.Domain.Domain;

namespace Larmo.Domain.Repositories
{
    public interface IProjectRepository
    {
        Project GetById(int projectId);
        Project GetByName(string name);
        Project GetByToken(string token);
        void Add(Project project);
        void Update(Project project);
    }
}