namespace AppointmentServer.Application.Features.Auth.Login
{
    //Result --> TS.Result

    public sealed record LoginCommandResponse(
        string Token);
}
