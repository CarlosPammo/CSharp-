using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows;
using EFE.Core;
using System.Windows.Controls;
using EFE.Entity;
using Expression = System.Linq.Expressions.Expression;

namespace RepositoryPattern
{

    public class Service
    {
        public List<T> Select<T>(T item, string column, string criteria, string option) where T : class
        {
            var type = typeof (T);
            var result = Expression.Parameter(type, "result");
            var property = type.GetProperty(column);
            var member = Expression.MakeMemberAccess(result, property);
            var propertyType = property.PropertyType;
            var parsedCriteria = Convert.ChangeType(criteria, propertyType);
            var searchCriteria = Expression.Constant(parsedCriteria, propertyType);

            var matching = option.Equals("Equals to")
                ? Expression.Equal(member, searchCriteria)
                : Expression.NotEqual(member, searchCriteria);
            var where = Expression.Lambda<Func<T, bool>>(matching, result);

            var repository = (new Factory<T>()).Get();

            var list = repository.Select(where);
            return list.ToList(); 
        }

        public PropertyInfo[] GetProperties<T>(T item) where T : class
        {
            var properties = typeof(T).GetProperties();

            return properties;
        }
    }

    public class CustomCB : ComboBoxItem
    {
        public Type Type { get; set; }
        public CustomCB(Type type)
        {
            Type = type;
            Content = type.Name;
        }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Service service = new Service();
        private dynamic changedObj;
        public MainWindow()
        {
            var types = new List<Type>
            {
                typeof(Area),
                typeof(Person)
            };
            InitializeComponent();
            CbOptions.Items.Add("Equals to");
            CbOptions.Items.Add("Different than");

            foreach (var type in types)
            {
                CbEntities.Items.Add(new CustomCB(type));
                var a = type.IsClass;

            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            var data = service.Select(changedObj, CbColumnas.Text, TbCriteria.Text, CbOptions.Text);

            DataGrid.DataContext = data;
        }

        private void CbEntities_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var test = (ComboBox) sender;
            var test2 = (CustomCB) test.SelectedItem;
            var test3 = test2.Type;
            
            var instance = Activator.CreateInstance(test3);

            changedObj = Convert.ChangeType(instance, test3);
            
            var properties = service.GetProperties(changedObj);
            CbColumnas.Items.Clear();
            foreach (var item in properties)
            {
                CbColumnas.Items.Add(item.Name);
            }
        }
    }
}
