using Soenneker.Dtos.StreetAddress;
using Soenneker.Utils.AutoBogus.Context;
using Soenneker.Utils.AutoBogus.Override;

namespace Soenneker.AutoFaker.Overrides.StreetAddresses;

/// <summary>
/// An AutoFaker (AutoBogus) override for the DTO StreetAddress
/// </summary>
public sealed class StreetAddressOverride : AutoFakerOverride<StreetAddress>
{
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as StreetAddress)!;

        target.Line1 = context.Faker.Address.StreetAddress();
        target.Line2 = context.Faker.Random.Bool() ? context.Faker.Address.SecondaryAddress() : null;
        target.City = context.Faker.Address.City();
        target.State = context.Faker.Address.StateAbbr();
        target.PostalCode = context.Faker.Address.ZipCode();
        target.Country = "US";
        target.Region = null;
        target.AdditionalInfo = null;
    }
}
