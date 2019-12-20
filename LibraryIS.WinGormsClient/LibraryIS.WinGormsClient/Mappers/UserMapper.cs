using LibraryIS.WinFormsClient.Dto;
using LibraryIS.WinFormsClient.Views;

namespace LibraryIS.WinFormsClient.Mappers
{
    public static class UserMapper
    {
        public static UserView MapToUserView(UserDto userDto)
        {
            return new UserView()
            {
                Id =  userDto.Id,
                Name = userDto.Name,
                Email =  userDto.Email,
                Password =  userDto.Password,
                Role =  userDto.Role
            };
        }
    }
}
