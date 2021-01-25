# Data Transformer
> A C# .NET Core implementation of data parser using design patterns.

This is a tech refresh of a set of legacy code that is designed to ingest and 
transform data structure for ease of reporting and display.

The original use case was to parse SNMP messages in a contextual meaningful way 
so that health statuses can be tracked and reported across existing systems.

## Getting started
### Preparing for local build & run
_TODO://_
- [ ] Dockerize solution
- [ ] Include steps to start/test drive the solution

### Code Walkthrough
Solution is structured into 3 separate concerns within a microservice architecture
* src\Services
  * Projects that exposes business operations via various integration channels 
    such as Web API, gRPC.
* src\Building Blocks
  * Projects that support the operations of services
    * side-car applications
    * utilities
    * integrations with infrastructures.
* tests\ServiceTests
  * Autonomous application functional tests based on agreed scenarios.
  * Automated tests with mock dependencies for each unit of work within managed code. 
* tests\BuildingBlockTests
  * Automated tests with mock dependencies for each unit of work within managed code.

### Initial Configuration
_TODO://_
- [ ] Include steps to modify environment variables, docker secrets for local development

## Developing
I strongly recommend using containers for local development.
Installation, maintenance and management of infrastructure
dependencies are so much easier.

_TODO://_
- [ ] Include steps to run automated tests
- [ ] Include steps to run docker images


## Building

_TODO://_
- [ ] Complete dockerization for build process.
- [ ] Include steps to build using docker

## Features

_TODO://_
- [ ] Include feature lists of code base.

## Configuration

_TODO://_
- [ ] Include list of environment variables and secrets
- [ ] Include examples when appropriate.

## Contributing
If you'd like to contribute, please fork the repository and use a feature
branch. Pull requests are warmly welcome on the **dev** branch

Kindly refer to [Contributing.md]() on coding style and guidelines
_TODO://_
- [ ] Create Contributing.md 

## Links
- Project homepage: ***TBD***
- Repository: https://github.com/Ez2Raven/data-transformation.git
- Issue tracker: ***TBD***
  - In case of sensitive bugs like security vulnerabilities, please contact
    ez2raven@gmail.com directly instead of using issue tracker. I appreciate your effort
    to improve the security and privacy of this project!

## Licensing
_TODO://_
- [ ] Replace close source license to open source, when appropriate