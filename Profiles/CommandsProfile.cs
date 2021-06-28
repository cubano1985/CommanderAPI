using AutoMapper;
using Commander.DTOs;
using Commander.Models;

namespace Commander.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //source -> Target 
            //Command -> ReadDTO
            CreateMap<Command, CommandReadDto>();
            //CreateDTO -> Command
            CreateMap<CommandCreateDto, Command>();
            //UpdateDTO -> Command
            CreateMap<CommandUpdateDto, Command>();
            //Command -> UpdateDTO
            CreateMap<Command, CommandUpdateDto>();
        }
    }
}