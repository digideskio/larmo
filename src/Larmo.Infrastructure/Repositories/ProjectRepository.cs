﻿using System;
using System.Data;
using Larmo.Domain.Domain;
using Larmo.Domain.Repositories;
using ServiceStack.OrmLite;

namespace Larmo.Infrastructure.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly IDbConnection _database;

        public ProjectRepository(IDbConnection databse)
        {
            _database = databse;
        }

        public Project GetById(int projectId)
        {
            return _database.SingleById<Project>(projectId);
        }

        public Project GetByName(string name)
        {
            return _database.Single<Project>(p => string.Equals(p.Name, name, StringComparison.CurrentCultureIgnoreCase));
        }

        public void Add(Project project)
        {
            _database.Insert(project);
        }
    }
}