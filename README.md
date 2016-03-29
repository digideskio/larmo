# LARMO

## What is it?

This project is a PoC of a central hub that stores information from many data feeds - control version systems, Skype, IRC, etc. - in order to have a clear project history with ability to search and analyse and sending out aggregated information to different media: web application, mobile application, email, IRC.

## Public API

```
GET /projects
GET /projects/{projectId}
POST /projects

GET /inputs
POST /inputs/github/{projectToken}
```

## Build & Run

Access to *Larmo*:

- [http://localhost:52298](http://localhost:52298)

## MVP - v0.1 TODO

- support for inputs: GitHub, GitLab, Trello (basic data + extras data)
- support for output: API
- managment of project (add, delete, update) + list, display details
- database migration process