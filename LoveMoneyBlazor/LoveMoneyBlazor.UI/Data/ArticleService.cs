using System;
using System.Linq;
using System.Threading.Tasks;

namespace LoveMoneyBlazor.Data
{
    public class ArticleService
    {
        private static readonly string[] Characters = new[]
        {
            "This is an example of an article title.",
            "Save the kittens'",
            "Save money by not spending any",
            "Investing options in media",
            "Shopping savings ideas",
            "You need to save for the future",
            "ISA options",
            "Investment platforms",
            "Car insurance saving plans",
            "It's a nice day outside"
        };
        private static readonly string[] ImageUrls = new[]
        {
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSNRBAdc9vPXuKSEcuwKaL_WpenULaH6xksPw&usqp=CAU",
            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT7-ctxA2sjzfFhZkRfrCAJKqw8SebLyj0rtQ&usqp=CAU",
            "https://lh3.googleusercontent.com/proxy/flYAyzRUfd_yhB_gHuLUx7Q-eTLGXFq-Tni2gEmbCKU0HLAIppUcK9yd6NjHV_3OIP0sbjrMv7eP1E_YIm9FvdKUApHxVZEK7UN5EgnSGSovI-qBffY"
        };
        private static readonly string[] Descriptions = new[]
        {
            "This a the article description paragraph."
        };

        public Task<Article[]> GetArticlesAsync()
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 4).Select(index => new Article
            {
                Title = Characters[rng.Next(Characters.Length)],
                Subheading = Characters[rng.Next(Characters.Length)],
                BackgroundImage = ImageUrls[rng.Next(ImageUrls.Length)],
                Description = Descriptions[rng.Next(Descriptions.Length)]
            }).ToArray());
        }
    }
}
