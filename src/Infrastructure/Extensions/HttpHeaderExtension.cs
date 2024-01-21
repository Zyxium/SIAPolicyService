using System.Net.Http.Headers;
using SIAPolicyService.Infrastructure.Configurations;

namespace SIAPolicyService.Infrastructure.Extensions;

public static class HttpHeaderExtension
{
    public static HttpClient SetGenerateToken(this HttpClient http, EnvironmentOptions options)
    {
        http.DefaultRequestHeaders.Add("Accept", "application/json");
        http.DefaultRequestHeaders.Add("sourceTransID", options.VIRIYAH_SOURCE_TRANS_ID);
        http.DefaultRequestHeaders.Add("clientID", options.VIRIYAH_CLIENT_ID);
        http.DefaultRequestHeaders.Add("clientSecret", options.VIRIYAH_CLIENT_SECRET);
        http.DefaultRequestHeaders.Add("requestTime", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"));
        http.DefaultRequestHeaders.Add("languagePreference", options.VIRIYAH_LANGUAGE_PREFERENCE);
        http.DefaultRequestHeaders.Add("grantType", options.VIRIYAH_GRANT_TYPE);
        http.DefaultRequestHeaders.Add("userName", options.VIRIYAH_USERNAME);
        http.DefaultRequestHeaders.Add("passWord", options.VIRIYAH_PASSWORD);
        http.DefaultRequestHeaders.Add("scope", options.VIRIYAH_SCOPE);
        
        return http;
    }   
    public static HttpClient SetValidateToken(this HttpClient http, EnvironmentOptions options, string jwtToken)
    {
        http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken);
        http.DefaultRequestHeaders.Add("Accept", "application/json");
        http.DefaultRequestHeaders.Add("sourceTransID", options.VIRIYAH_SOURCE_TRANS_ID);
        http.DefaultRequestHeaders.Add("clientID", options.VIRIYAH_CLIENT_ID);
        http.DefaultRequestHeaders.Add("clientSecret", options.VIRIYAH_CLIENT_SECRET);
        http.DefaultRequestHeaders.Add("requestTime", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"));
        http.DefaultRequestHeaders.Add("languagePreference", options.VIRIYAH_LANGUAGE_PREFERENCE);
        
        return http;
    }   
    
    public static HttpClient SetIssueToken(this HttpClient http, EnvironmentOptions options, string jwtToken)
    {
        http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken);
        http.DefaultRequestHeaders.Add("Accept", "application/json");
        http.DefaultRequestHeaders.Add("sourceTransID", options.VIRIYAH_SOURCE_TRANS_ID);
        http.DefaultRequestHeaders.Add("clientID", options.VIRIYAH_CLIENT_ID);
        http.DefaultRequestHeaders.Add("clientSecret", options.VIRIYAH_CLIENT_SECRET);
        http.DefaultRequestHeaders.Add("requestTime", DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"));
        http.DefaultRequestHeaders.Add("languagePreference", options.VIRIYAH_LANGUAGE_PREFERENCE);
        
        return http;
    }   
}

