<h1 align="center">
Anki</h1>
<p align="center">
  <a href="https://github.com/marcuscfarias/anki/issues"><img alt="number of issues for the repository" src="https://img.shields.io/github/issues/marcuscfarias/anki?color=red&label=Issues&style=for-the-badge" target="_blank" /></a>
  <a href="https://github.com/marcuscfarias/anki"><img alt="the size of the repo in kb" src="https://img.shields.io/github/repo-size/marcuscfarias/anki?color=orange&label=Repo-Size&style=for-the-badge" target="_blank" /></a>
  <a href="https://opensource.org/licenses/MIT"><img alt="licence the repo is published under" src="https://img.shields.io/badge/License-MIT-yellow?style=for-the-badge" target="_blank" /></a>
 <a href="https://github.com/marcuscfarias/anki/graphs/contributors"><img alt="the number of contributors on the repo" src="https://img.shields.io/github/contributors/marcuscfarias/anki?color=brightgreen&label=Contributors&style=for-the-badge" target="_blank" /></a>
  <a href="https://github.com/marcuscfarias/anki/network/members"><img alt="total number of times the repo has been forked" src="https://img.shields.io/github/forks/marcuscfarias/anki?color=blue&label=Forks&style=for-the-badge" target="_blank" /></a>
  <a href="https://github.com/marcuscfarias/anki/stargazers"><img alt="total number of times the repo has been starred" src="https://img.shields.io/github/stars/marcuscfarias/anki?color=blueviolet&label=Stars&style=for-the-badge" target="_blank" /></a>
</p>

## 1. About this project

#### 1.1 Overview

This project is a full-stack web application inspired by Anki, designed to help users efficiently learn and retain
information through spaced repetition. It is built with a .NET Core backend and a React frontend, providing a modern and
scalable architecture for both performance and maintainability.

The application enables users to create, organize, and review flashcards, manage study decks, and track progress over
time — offering a flexible foundation for personalized learning.

The main goal of this project is to strengthen my skills in software architecture and full-cycle development, covering
every stage from backend and frontend implementation to deployment and production readiness. The project is currently
under active development, with a working prototype coming soon.

#### 1.2 Demo

Check the project demo in the following link: (not deployed yet)

Or you can see the photos below.

## 2. Project design

#### 2.1 Database schema

#### 2.2 Technologies

#### 3.2 Frameworks

#### 3.3 Architecture and patterns

## 3. Feature Table

#### Status: `⏳ Planned` &rarr; `⚙️ In Progress` &rarr; `✅ Done`

| ID |       Feature        |                        Description                         |   Status    |
|:--:|:--------------------:|:----------------------------------------------------------:|:-----------:|
| 1  |       Database       |           implement and draw all database schema           | `⏳ Planned` |
| 2  |      User CRUD       |             create, read, update, delete users             | `⏳ Planned` |
| 3  |    Authentication    |              secure signup, signin and logout              | `⏳ Planned` |
| 4  |    Authorization     | role-based access control and multi-tenancy (scholar plan) | `⏳ Planned` |
| 5  | Configuration CI/CD  |                                                            | `⏳ Planned` |
| 6  |   Azure Deployment   |                                                            | `⏳ Planned` |
| 7  | Notification Service |              secure signup, signin and logout              | `⏳ Planned` |
| 8  |   Payment Service    |                      Asaas or stripe                       | `⏳ Planned` |
| 9  |   Caching strategy   |                         add redis                          | `⏳ Planned` |
| 10 |    Config Scalar     |               change swagger docs to scalar                | `⏳ Planned` |
| 11 |    IA integration    |                  build decks with api key                  | `⏳ Planned` |
| 12 |      Front-End       |                     react and lovable                      | `⏳ Planned` |
| 13 |        HTTPS         |                    generate certificate                    | `⏳ Planned` |

## 4. Getting started

## 5. Contributing

You can send how many PR's do you want, I'll be glad to analyse and accept them! And if you have any question about the
project just ask...

## 6. License

This project is licensed under the MIT License - see
the [LICENSE.md](https://github.com/marcuscfarias/anki/blob/main/README.md) file for details

## 7. More technical details

#### Users
```
- [ ] JWT Authentication
- [ ] Authorization (role-base and claim access control)
- [ ] Password hashing (BCrypto)
- [ ] Multi-tenancy application (discriminator column, tenant context resolution by header using middleware)
- [ ] Rate limiting per user
- [ ] CPF Validation
```

### Generic Features
```
- [ ] Generic exceptions (structure logs with sentry)
- [ ] Global error handler middleware
- [ ] Global validation filter
```

### Notification Features
```
- [ ] Email/SMS reminders for appointments using a background service, outbox pattern.
- [ ] IHostedService and webhooks
```

### Payment Integration (Asaas)
```
- [ ] still thinking about this
- [ ] Subscription Workflow (Update payment status based on webhook)
- [ ] Payment Statuses (Pending, Paid, Failed, Canceled, Expired)
```

### Roles features
```
- [ ] Admin – Full control over CRUD and payments
- [ ] Instructor (optional) – Can create/update their own courses
- [ ] Student – Can enroll, access classes, track progress
```

### Caching with redis features
```
- [ ] still thinking about this
```

### Logging features
```
- [ ] still thinking about this (Serilog)
```

### Architecture and Design:
```
- [ ] Repository
- [ ] Clean Architecture
- [ ] Domain Driven Design
- [ ] Command Query Responsibility Segregation
- [ ] TDD (unit and integration tests)
```

### Deployment:
```
- [ ] CD/CI with GitHub actions (Build & Test, Dockerize API, Push Image to GitHub Container Registry, Push Image to
  GitHub Container Registry)
- [ ] App Service Azure
- [ ] Key Vault
- [ ] Dev and Prod environment
- [ ] config environment variables and secrets
```

### Documentation
```
- [ ] automatically generate them
```