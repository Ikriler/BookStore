   M S B A M L   `   `   `  ����G  CBookStoreWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:BookStoreWpf.Pages.AdminBookStoreWpf.Pages.Admin  5      1    +BookStoreWpf.Pages.Admin.AdminCreateProduct   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:BookStoreWpf.Pages.Admin     5        N� Title$  AdminCreateProduct��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��1��6   $��1��6   $��Название��6-   $��2��6@      labelDefault#��[  6T   �� 5    
   $��2��6   $��1��6   $��Описание��6-   $��2��6@   #��[  6T   �� 5!   
   $��3��6   $��1��6   $��Количество��6-   $��2��6B   #��[  6V   �� 5"   
   $��4��6   $��1��6   $-��'Название изображения��6-   $��2��6L   #��[  6`   �� 5#   
   $��5��6   $��1��6   $��Цена��6-   $��2��6<   #��[  6P   �� 5%   
   -   5        $��NameTB��5%      $��1��6    $��3��6-   $��3��6=   $��5q�6Q     textBoxDefault#��[ 6\   �� 5&   
   -   5        $��DescriptionTB��5&      $��2��6'   $��3��64   $��3��6D   $��5q�6X   #��[ 6c   �� 5'   
   -   5        $��
QunatityTB��5'      $��3��6$   $��3��61   $��3��6A   $��5q�6U   #��[ 6`   �� 5(   
   -   5        $��ImagePathTB��5(      $��4��6%   $��3��62   $��3��6B   $��5q�6V   #��[ 6a   �� 5)   
   -   5        $��PriceTB��5)      $��5��6!   $��3��6.   $��3��6>   $��5q�6R   #��[ 6]   �� 5+   
   $��6��6   $��1��6"   $��5��62   $��Center=�6F   .+�5,      �� -   5        $��SaveProduct��5,      $��Сохранить��6(     buttonDefault#��[ 6<   $��40��6c   6o   5-      5.      5/      