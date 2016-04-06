# LARMO

## What is it?

This project is a PoC of a central hub that stores information from many data feeds - control version systems, Skype, IRC, etc. - in order to have a clear project history with ability to search and analyse and sending out aggregated information to different media: web application, mobile application, email, IRC.

## Is it really working?

Yes, you can check the webapp under http://larmohub.azurewebsites.net - it's currently connected to our Github repo.

## MVP - v0.1 TODO

- support for inputs: GitHub, GitLab, Trello (basic data + extras data)
- support for output: API
- managment of project (add, delete, update) + list, display details
- database migration process

## Public API

Method | Endopoint | Description
-------|-----------|------------
```GET``` | ```/projects``` |
```GET``` | ```/projects/{projectId}``` |
```POST``` | ```/projects``` |
```GET``` | ```/inputs``` |
```POST``` | ```/inputs/github/{projectToken}``` |

## Supported Inputs

- GitHub webhooks
  - create, delete, pull_request, push, issues, gollum

## How to run?

1. Create database and load table schema from ```database.sql```
2. Setup connection string to database in "Web.config" (variable ```DATABASE_CONNECTION_STRING```)
3. Build and run
4. Access to *Larmo* - [http://localhost:52298](http://localhost:52298)