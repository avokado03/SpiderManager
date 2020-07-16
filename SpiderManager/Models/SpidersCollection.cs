using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace SpiderManager.Models
{
    public class SpidersCollection : BindableBase
    {
        private readonly ObservableCollection<Spider> _spiders = new ObservableCollection<Spider>();
        public readonly ReadOnlyCollection<Spider> spiders;

        public SpidersCollection()
        {
            spiders = new ReadOnlyCollection<Spider>(_spiders);
        }

        public void AddSpider(Spider spider)
        {
            _spiders.Add(spider);
        }

        public void RemoveSpider(int spiderId)
        {
            var spiderOnDelete = _spiders.SingleOrDefault(x => x.Id == spiderId);
            if (spiderOnDelete != null)
            {
                _spiders.Remove(spiderOnDelete);
            }
            else
            {
                throw new NullReferenceException("Паука с заданным Id нет в коллекции");
            }
        }
    }
}
