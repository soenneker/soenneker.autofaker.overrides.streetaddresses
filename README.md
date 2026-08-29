[![](https://img.shields.io/nuget/v/soenneker.autofaker.overrides.streetaddresses.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.streetaddresses/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.streetaddresses/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.streetaddresses/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.autofaker.overrides.streetaddresses.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.streetaddresses/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.streetaddresses/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.streetaddresses/actions/workflows/codeql.yml)

# Soenneker.AutoFaker.Overrides.StreetAddresses

An AutoFaker override for generating US-style `StreetAddress` fixtures.

## Installation

```bash
dotnet add package Soenneker.AutoFaker.Overrides.StreetAddresses
```

## Usage

```csharp
using Soenneker.AutoFaker.Overrides.StreetAddresses;
using Soenneker.Dtos.StreetAddress;
using Soenneker.Utils.AutoBogus;

var autoFaker = new AutoFaker();
autoFaker.Config.Overrides = [new StreetAddressOverride()];

StreetAddress address = autoFaker.Generate<StreetAddress>();
```

The override fills street, city, state abbreviation, and ZIP code, sets `Country` to `US`, and sometimes supplies `Line2`. `Region` and `AdditionalInfo` are cleared. The values are synthetic and are not validated as a real deliverable address.
