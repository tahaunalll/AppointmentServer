﻿using MediatR;
using TS.Result;

namespace AppointmentServer.Application.Features.Auth.Login
{
    public sealed record LoginCommand(
        string UserNameOrEmail,
        string Password
        ) : IRequest<Result<LoginCommandResponse>>;
}
