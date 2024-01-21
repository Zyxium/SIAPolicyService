using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SIAPolicyService.Infrastructure.Configurations;

[ExcludeFromCodeCoverage]
public class EnvironmentOptions
{
    [Required] public string ASPNETCORE_ENVIRONMENT { get; init; }
    [Required] public string API_KEYS { get; init; }
    [Required] public string BASIC_AUTHENTICATION_USERNAME { get; init; }
    [Required] public string BASIC_AUTHENTICATION_PASSWORD { get; init; } 
    [Required] public string SQLSERVER_CONNECTIONSTRING { get; init; }
    
    [Required] public string VIRIYAH_API_ENDPOINT { get; init; }
    [Required] public string VIRIYAH_SOURCE_TRANS_ID { get; init; }
    [Required] public string VIRIYAH_CLIENT_ID { get; init; }
    [Required] public string VIRIYAH_CLIENT_SECRET { get; init; }
    [Required] public string VIRIYAH_LANGUAGE_PREFERENCE { get; init; }
    [Required] public string VIRIYAH_GRANT_TYPE { get; init; }
    [Required] public string VIRIYAH_USERNAME { get; init; }
    [Required] public string VIRIYAH_PASSWORD { get; init; }
    [Required] public string VIRIYAH_SCOPE { get; init; }
}