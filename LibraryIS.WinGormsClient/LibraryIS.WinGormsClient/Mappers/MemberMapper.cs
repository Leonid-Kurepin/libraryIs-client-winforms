using LibraryIS.WinFormsClient.Dto;
using LibraryIS.WinFormsClient.Views;

namespace LibraryIS.WinFormsClient.Mappers
{
    public static class MemberMapper
    {
        public static MemberView MapToMemberView(MemberDto memberDto)
        {
            return new MemberView()
            {
                Id = memberDto.Id,
                Name = memberDto.Name,
                PassportNumber = memberDto.PassportNumber,
                PassportSeries = memberDto.PassportSeries,
                DateOfBirth = memberDto.DateOfBirth,
                CountOfBooks = memberDto.CountOfBooks,
                IsInBlacklist = memberDto.IsInBlacklist
            };
        }
    }
}
