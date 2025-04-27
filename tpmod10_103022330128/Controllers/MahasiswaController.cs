using Microsoft.AspNetCore.Mvc;
using tpmod10_103022330128;

namespace tpmodul10_103022330128.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa("Abizar Tsaqif Abrar", "10302233028"),
            new Mahasiswa("Ahmad Naufal Al Ghiffari", "103022300006"),
            new Mahasiswa("Maulana Jidan Azizi", "103022300083"),
            new Mahasiswa("Wildan Nabil Ramdhany", "103022300095"),
            new Mahasiswa("Elvina Nilysti Huang", "1030223000145"),
            new Mahasiswa("Hafidz Zuhayr Shiddiq", "103022300019"),
            new Mahasiswa("Mikdam Huda", "130223034")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswaList;
        }

        [HttpGet("{index}")]
        public Mahasiswa Get(int index)
        {
            return mahasiswaList[index];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mhs)
        {
            mahasiswaList.Add(mhs);
        }

        [HttpDelete("{index}")]
        public void Delete(int index)
        {
            mahasiswaList.RemoveAt(index);
        }
    }
}