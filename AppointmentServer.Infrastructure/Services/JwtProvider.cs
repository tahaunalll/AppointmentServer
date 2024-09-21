using AppointmentServer.Application.Services;
using AppointmentServer.Domain.Entities;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AppointmentServer.Infrastructure.Services
{
    //Microsoft.AspNetCore.Authentication.JwtBearer NUget
    internal sealed class JwtProvider : IJwtProvider
    {
        public string CreateToken(AppUser user)
        {
            //System.Security.Claims
            List<Claim> claims = new()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.FullName),
                new Claim(ClaimTypes.Email, user.Email?? string.Empty),
                new Claim("UserName", user.UserName?? string.Empty)
            };

            DateTime expires = DateTime.Now.AddDays(1);

            SymmetricSecurityKey securityKey = new(Encoding.UTF8.GetBytes(string.Join("-", Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid())));
            SigningCredentials signingCredentials = new(securityKey,SecurityAlgorithms.HmacSha512);
            
            JwtSecurityToken jwtSecurityToken = new(

                issuer: "Taha Turgut Unal",
                audience: "Appointment",
                claims:claims,
                notBefore: DateTime.Now,
                expires: expires,
                signingCredentials: signingCredentials
                );

            JwtSecurityTokenHandler handler = new();
            string token = handler.WriteToken(jwtSecurityToken);
            return token;


        }
    }
}
