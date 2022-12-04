using Avalonia.Interactivity;
using AvaloniaEntityFrameworkExemple.Data;
using AvaloniaEntityFrameworkExemple.Models;
using Microsoft.EntityFrameworkCore;
using SkiaSharp;
using System.Collections.ObjectModel;
using System.Linq;

namespace AvaloniaEntityFrameworkExemple.ViewModels
{
    public class MainWindowViewModel : ViewModelBase {
        private Database _db;

        ObservableCollection<Category> Categories { get; } = new();
        ObservableCollection<Product> Products { get; } = new();

        public MainWindowViewModel(Database db)
        {
            _db = db;

            Load();
        }

        public void Load()
        {
            // this forces the grid to refresh to latest values
            foreach (var item in Categories.ToList()) Categories.Remove(item);
            foreach (var item in Products.ToList()) Products.Remove(item);

            foreach (var item in _db.Categories) Categories.Add(item);
            foreach (var item in _db.Products) Products.Add(item);
        }

        public void Save()
        {
            // all changes are automatically tracked, including
            // deletes!
            _db.SaveChanges();
        }

    }
}
