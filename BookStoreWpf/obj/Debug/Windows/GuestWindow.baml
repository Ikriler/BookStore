   M S B A M L   `   `   `  ����G  CBookStoreWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:BookStoreWpf.WindowsBookStoreWpf.Windows  5   	   &     BookStoreWpf.Windows.GuestWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:BookStoreWpf.Windows     5   	     � Title$  GuestWindow��5   	   $	��450��6   $	��800��6*   $	��450��66   $	��800��6F   .��5	      �  � ColumnDefinitions 5
   
   �� 5       � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      .+�5   
    � -   5        $��
GuestFrame��5      $��1��6"     � NavigationUIVisibility$ Hidden=�6/   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��Center=�6I   .+�5      �� -   5        $��GoMain��5      $��На главную��6#      buttonDefault#��[  68   $��0 0 20 0q�6k   6}   �� 5      -   5        $��GoOrder��5      $��Корзина��6$   #��[  66   $��0 0 20 0q�6i   6{   �� 5      -   5        $��GoExit��5      $��
Выйти��6#   #��[  63   6f   5      5      5      