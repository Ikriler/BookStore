   M S B A M L   `   `   `  ����G  CBookStoreWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BookStoreWpfBookStoreWpf  5   	       BookStoreWpf.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:BookStoreWpf     5   	     � Title$  LoginWindow��5   	   $	��450��6   $	��800��6*   $	��450��66   $	��800��6F    � WindowStartupLocation$ CenterScreen=�6U   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��0.3* �6   �� 5      $
��0.5* �6   �� 5      �� 5      $
��0.5* �6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $��1��6   $��1��6       labelDefault#��[  6-   .��6_   Email6f   �� 5   
   -   5        $��EmailTB��5      $��1��6!   $��2��6.   $��15q�6>     textBoxDefault#��[ 6J   �� 5   
   $��1��6   $��2��6    #��[  6-   .��6_   
Password6i   G� 5   
   -   5        $��
PasswordPB��5      $��2��6(   $��2��65   $��15q�6E     passwordBoxDefault#��[ 6Q   �� 5   
   $��1��6   $��3��6%   $��2��62    �� Orientation$ 
Horizontal=�6F   $��Center=�6_   $��Center=�6z   .+�5      �� -   5        $��UserEnterBtn��5      $��
Войти��6)     buttonDefault#��[ 69   $��	70 0 20 0q�6l   6   �� 5      -   5        $��GuestEnterBtn��5      $"��Войти как гость��6*   #��[ 6D   $	��200��6w   6�   5      �� 5    
   $��0��6   $��4��6%   $��4��62   $ 
Horizontal=�6F   $��Center=�6_   $��Center=�6z   .+�5!      �� -   5        $��AdminEnterTestBtn��5!      $"��Войти как админ��6.   #��[ 6H   $��0 0 20 0q�6{   $	��200��6�   6�   �� 5"      -   5        $��ClientEnterTestBtn��5"      $$��Войти как клиент��6/   #��[ 6J   $��0 0 20 0q�6}   $	��200��6�   6�   �� 5#      -   5        $��ManagerEnterTestBtn��5#      $&�� Войти как менджер��60   #��[ 6L   $	��200��6   6�   5$      5%      5&      