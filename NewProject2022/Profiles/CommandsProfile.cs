using AutoMapper;
using NewProject2022.DTOs;
using NewProject2022.Models;

namespace NewProject2022.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //Source => Target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}

