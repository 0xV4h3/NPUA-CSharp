using Practical7.Models;
using Newtonsoft.Json;

public class SeedData
{
    [JsonProperty("departments")]
    public System.Collections.Generic.List<Department> Departments { get; set; }
    [JsonProperty("groups")]
    public System.Collections.Generic.List<Group> Groups { get; set; }
    [JsonProperty("userProfiles")]
    public System.Collections.Generic.List<UserProfile> UserProfiles { get; set; }
    [JsonProperty("userGroupMemberships")]
    public System.Collections.Generic.List<UserGroupMembership> UserGroupMemberships { get; set; }
}
