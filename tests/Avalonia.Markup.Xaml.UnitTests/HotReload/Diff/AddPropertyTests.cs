//using Avalonia.Controls;
//using Avalonia.Styling;
//using Avalonia.UnitTests;
//using Xunit;

//namespace Avalonia.Markup.Xaml.UnitTests.HotReload.Diff
//{
//    public class AddPropertyTests : DiffTestBase
//    {
//        [Fact]
//        public void AddSimpleProperties()
//        {
//            using (UnitTestApplication.Start(TestServices.StyledWindow))
//            {
//                var xaml = @"
//<UserControl xmlns='https://github.com/avaloniaui'
//             xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'
//             x:Class='Avalonia.Markup.Xaml.UnitTests.HotReload.TestControl'>
//  <Border Background='Yellow' />
//</UserControl>";
                
//                var modifiedXaml = @"
//<UserControl xmlns='https://github.com/avaloniaui'
//             xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'
//             x:Class='Avalonia.Markup.Xaml.UnitTests.HotReload.TestControl'>
//  <Border Padding='20' HorizontalAlignment='Center' Background='Yellow' />
//</UserControl>";

//                var diff = GetDiffBlocks<TestControl>(xaml, modifiedXaml);
                
//                Assert.Empty(diff.AddedBlocks);
//                Assert.Empty(diff.BlockMap);
//                Assert.Empty(diff.RemovedBlocks);
//                Assert.Empty(diff.PropertyMap);
//                Assert.Empty(diff.RemovedProperties);
                
//                Assert.Equal(diff.AddedProperties.Count, 2);
//                Assert.Equal(diff.AddedProperties[0].Parent.Type, typeof(Border).FullName);
//                Assert.Equal(diff.AddedProperties[1].Parent.Type, typeof(Border).FullName);
//                Assert.Equal(diff.AddedProperties[0].Name, "Padding");
//                Assert.Equal(diff.AddedProperties[1].Name, "HorizontalAlignment");
//            }
//        }
        
//        [Fact]
//        public void AddPropertiesWithSameTypeSiblings()
//        {
//            using (UnitTestApplication.Start(TestServices.StyledWindow))
//            {
//                var xaml = @"
//<UserControl xmlns='https://github.com/avaloniaui'
//             xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'
//             x:Class='Avalonia.Markup.Xaml.UnitTests.HotReload.TestControl'>
//  <StackPanel>
//    <TextBlock Foreground='Yellow' />
//    <TextBlock />
//  </StackPanel>
//</UserControl>";
                
//                var modifiedXaml = @"
//<UserControl xmlns='https://github.com/avaloniaui'
//             xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'
//             x:Class='Avalonia.Markup.Xaml.UnitTests.HotReload.TestControl'>
//  <StackPanel>
//    <TextBlock Foreground='Yellow' Text='Text' />
//    <TextBlock Foreground='Green' />
//  </StackPanel>
//</UserControl>";

//                var diff = GetDiffBlocks<TestControl>(xaml, modifiedXaml);
                
//                Assert.Empty(diff.AddedBlocks);
//                Assert.Empty(diff.BlockMap);
//                Assert.Empty(diff.RemovedBlocks);
//                Assert.Empty(diff.PropertyMap);
//                Assert.Empty(diff.RemovedProperties);
                
//                Assert.Equal(diff.AddedProperties.Count, 2);
//                Assert.Equal(diff.AddedProperties[0].Parent.Type, typeof(TextBlock).FullName);
//                Assert.Equal(diff.AddedProperties[1].Parent.Type, typeof(TextBlock).FullName);
//                Assert.Equal(diff.AddedProperties[0].Parent.ParentIndex, 0);
//                Assert.Equal(diff.AddedProperties[1].Parent.ParentIndex, 1);
//                Assert.Equal(diff.AddedProperties[0].Name, "Text");
//                Assert.Equal(diff.AddedProperties[1].Name, "Foreground");
//            }
//        }

//        [Fact]
//        public void AddExpandedProperty()
//        {
//            using (UnitTestApplication.Start(TestServices.StyledWindow))
//            {
//                var xaml = @"
//<UserControl xmlns='https://github.com/avaloniaui'
//             xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'
//             x:Class='Avalonia.Markup.Xaml.UnitTests.HotReload.TestControl'>
//  <StackPanel>
//    <TextBlock />
//  </StackPanel>
//</UserControl>";

//                var modifiedXaml = @"
//<UserControl xmlns='https://github.com/avaloniaui'
//             xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'
//             x:Class='Avalonia.Markup.Xaml.UnitTests.HotReload.TestControl'>
//  <StackPanel>
//    <TextBlock>
//      <TextBlock.Styles>
//        <Style Selector='TextBlock.h1'>
//          <Setter Property='Margin' Value='50' />
//        </Style>
//      </TextBlock.Styles>
//    </TextBlock>
//  </StackPanel>
//</UserControl>";

//                var diff = GetDiffBlocks<TestControl>(xaml, modifiedXaml);

//                Assert.Empty(diff.BlockMap);
//                Assert.Empty(diff.RemovedBlocks);
//                Assert.Empty(diff.AddedProperties);
//                Assert.Empty(diff.PropertyMap);
//                Assert.Empty(diff.RemovedProperties);

//                Assert.Equal(diff.AddedBlocks.Count, 1);
//                Assert.Equal(diff.AddedBlocks[0].Type, typeof(Style).FullName);
//                Assert.Equal(diff.AddedBlocks[0].ParentProperty.Name, "Style");
//            }
//        }
//    }
//}
