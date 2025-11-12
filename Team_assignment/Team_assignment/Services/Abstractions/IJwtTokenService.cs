namespace Team_assignment.Services.Abstractions;

public interface IJwtTokenService
{
    public Task<string> CreateTokenAccessAsync(int id);
    public Task<string> GenerateJwtToken(int id);
}