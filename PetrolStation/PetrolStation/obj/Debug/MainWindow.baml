   M S B A M L   `   `   `  ����H  DPetrolStation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:PetrolStation.ViewModelPetrolStation.ViewModel  5   	       PetrolStation.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:PetrolStation.ViewModel     5   	     � Title$  PetrolStation��5   	   $	��400��6   $	��600��6,    � DataContext 5	      4   .PetrolStation.ViewModel.PetrolStationViewModel  5
   
   .��5      ]� $��Stretch=�5   	   $
��Auto��5   	   .+�5   
   ]� $��Stretch=�5      $��Stretch=�5      $
��Auto��5      $	��100��5      $��10q�5      .+�5      � $��	0 10 10 0q�6   $
��Auto��6&    � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$    � ColumnDefinitions 5      �� 5      .+�5"      � $��0��6   $��0 0 0 5q�6)   .+�5#      �� $��	Category:��6   $��81��60   6=   �� 5$      $	��150��6B   ��6   �� *
Categories+ �� SelectedItem 5%      �� *SelectedCategory+ �� Mode$ TwoWay=���5&      �� 5'      .R�5(   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5)   &   �� $��0,2,5,2q�6F   ��60   �� *Name+6F   �� 5*   &   ��60   �� *Name+5+   #   5,      5.      5/      � 51      $��1��6   $��0 0 0 5q�6)   .+�52      �� $��SubCategory:��6   65   �� 53      $	��150��6H   ��6   �� *SubCategoriesCmb+{�54      �� *IsEnabledSubCatCmb+ 55      �� *SelectedSubCategory+$ TwoWay=���56      �� 57      .R�58   "   �� $ 
Horizontal=�6-   .+�59   &   �� $��0,2,5,2q�6F   ��60   �� *Name+6F   �� 5:   &   ��60   �� *Name+5;   #   5<      5>      5?      � 5A      $��2��6   .+�5B      �� $��Product:��6   $��74��6/   6<   �� 5C      $��7 0 0 0q�5D      $	��150��5E      ��5C      �� *ProductName+ �� UpdateSourceTrigger$ PropertyChanged=�{�5F      �� *IsEnabledTextProduct+.��6I   5G      5H      �� 5J      $��3��6   $��	81,10,0,0q�5K      $	��Add��5M      ��5L      �� *
AddProduct+5M      5O      5Q      ]� 5R   
   $��Stretch=�5S      $��Stretch=�5T      $
��Auto��5U      $	��250��5V      $��10q�5W      .+�5Y      R� -   5         R�Name$ CategoryTreeView��5Y      ��5Z      �� 	 �� Path$	 
Categories���5[      �� 5\      
 �� ItemsSource
 6/   �� $	 SubCategories�.R�5]      �� ��6    �� *Name+ �� ItemTemplate 5^      �� 5_      
 67   �� $	 Products�.R�5`   "   �� ��6(   �� *Name+5a      5c      5e      5g      5h      5i      