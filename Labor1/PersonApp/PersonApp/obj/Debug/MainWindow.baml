   M S B A M L   `   `   `  ����D  @PersonApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PersonApp	PersonApp  5   	       PersonApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:PersonApp     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��0��6   $��2��6$   $��Personal Information��68   $��36(�6T   $��15, 0, 0, 10q�6b   �� 5   
   $��0��6   $��1��6$   $��
First Name��61   $��26(�6C   $��15, 0, 0, 10q�6Q   �� 5   
   $��0��6   $��2��6$   $��	Last Name��61   $��26(�6B   $��15, 0, 0, 10q�6P   �� 5   
   -   5         ��Name$ txtBxFirstName��5      $��1��6*   $��1��6:   $�� ��6G   $��26(�6O   $��0, 0, 0, 10q�6]   �� 5   
   -   5        $ txtBxLastName��5      $��1��6)   $��2��69   $�� ��6F   $��26(�6N   $��0, 0, 0, 10q�6\   �� 5   
   -   5         ��Name$ 
bttnSubmit��5      $��0��6%   $��2��65   $��3��6I   $��Run me��6V   $��24(�6g   $��25, 15, 5, 15q�6u   6�   �� 5   
   -   5         ��Name$ cmbBxPeopleName��5      $��0��6,   $��2��6<   $��4��6P   $��25, 5, 5, 25q�6]   ��5       �� 5!      .R�5"      ��  �� Orientation$ 
Horizontal=�6!   .+�5#      �� $B��<C:\Egyetem\.Net\.NET-laborgyakorlat\PersonApp\src\avatar.png��6    $��30��6f   $��30��6r   �� 5$      $��24(�6>   ��6$   �� *
FullName+6>   5%      5&      5(      �� 5*   
   $��1��6   $��2��6$   $��6��64   $��2��6E   $��25, 25, 25, 25q�6Y   .��5+      �� $ Vertical=�6   .+�5,      �� $	��200��6   $	��200��6(   $,��&D:\net\Labor1\PersonApp\src\avatar.png��67   $��10q�6g   �� 5-      $	��200��6   $	��200��6(   $,��&D:\net\Labor1\PersonApp\src\avatar.png��67   $��10q�6g   �� 5.      $	��200��6   $	��200��6(   $,��&D:\net\Labor1\PersonApp\src\avatar.png��67   $��10q�6g   �� 5/      $	��200��6   $	��200��6(   $,��&D:\net\Labor1\PersonApp\src\avatar.png��67   $��10q�6g   50      51      53      54      