using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Application.Dto
{
    public class BlockAddDto
    {
        public Guid UserId { get; set; }
        public  List<BlockAddDto> BlockAddDtos { get; set; }
    }

    public class BlockViewDto
    {
        public int Id { get; set; }
        public int BlocktId { get; set; }
        public List<BlockViewDto> Items { get; set; }
        public string UserName { get; set; }
        public Guid UserId { get; set; }
      
    }
}
