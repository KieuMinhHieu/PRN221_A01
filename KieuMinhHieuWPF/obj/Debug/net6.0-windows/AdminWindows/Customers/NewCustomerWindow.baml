   M S B A M L   `   `   `  ����J  FKieuMinhHieuWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:KieuMinhHieuWPF.AdminWindows.Customers&KieuMinhHieuWPF.AdminWindows.Customers  5   	   >    8KieuMinhHieuWPF.AdminWindows.Customers.NewCustomerWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:KieuMinhHieuWPF.AdminWindows.Customers     5   	     � Title$  NewCustomerWindow��5   	   $	��550��6#   $	��800��60   .��5	      �� .+�5
   
   �� $��New Customer��6   
 �� Top$ 8��6(    �� Left$ 66��67   $
��Left=�6H   $	��Top=�6c   $	��224��6{   $��43��6�   $��26(�6�   $
��Bold"�6�   �� 5   
   $��Email��6   $ 60��6    $��Center=�62   $	��Top=�6O   $��36��6g   $��90��6s   $��18(�6~   $	 114��6�   �� 5   
   $
��Name��6   $ 69��6   $ 60��60   $
��Left=�6B   $��Center=�6]   $��36��6x   $��90��6�   $��18(�6�   �� 5   
   $
��City��6   $ 60��6   $��Center=�61   $	��Top=�6N   $��36��6f   $��90��6r   $��18(�6}   $	 168��6�   �� 5   
   $��Country��6   $ 60��6"   $��Center=�64   $	��Top=�6Q   $��36��6i   $��90��6u   $��18(�6�   $	 222��6�   �� 5   
   $��Password��6   $ 60��6#   $��Center=�65   $	��Top=�6R   $��36��6j   $��90��6v   $��18(�6�   $	 276��6�   �� 5   
   $��Birthday��6   $ 60��6#   $��Center=�65   $	��Top=�6R   $��36��6j   $��90��6v   $��18(�6�   $	 384��6�   �� 5   
   $��Confirm Password��6   $ 60��6+   $��Center=�6=   $	��Top=�6Z   $��36��6r   $	��158��6~   $��18(�6�   $	 330��6�   �� 5   
   -   5         ��Name$ txtName��5      $	 230��6#    �� TextWrapping$
 Wrap=�65   $ 69��6J   $	��429��6Z   $��36��6f   $��18(�6r   $
��Left=�6�   $��Center=�6�   $��Center=�6�   �� 5   
   -   5        $ txtEmail��5      $	 230��6$   $
 Wrap=�66   $	 114��6K   $	��429��6]   $��36��6i   $��18(�6u   $��Center=�6�   $	��Top=�6�   $��Center=�6�   �� 5   
   -   5        $ txtCity��5      $	 230��6#   $
 Wrap=�65   $	 168��6J   $	��429��6\   $��36��6h   $��18(�6t   $��Center=�6�   $	��Top=�6�   $��Center=�6�   �� 5   
   -   5        $ 
txtCountry��5      $	 230��6&   $
 Wrap=�68   $	 222��6M   $	��429��6_   $��36��6k   $��18(�6w   $��Center=�6�   $	��Top=�6�   $��Center=�6�   G� 5   
   -   5         G�Name$ txtPassword��5      $	 230��6+   $	 276��6=   $	��429��6O   $��36��6[   $��18(�6g   $��Center=�6u   $	��Top=�6�   $��Center=�6�   G� 5   
   -   5        $ txtConfirmPassword��5      $	 230��62   $	 330��6D   $	��429��6V   $��36��6b   $��18(�6n   $��Center=�6|   $	��Top=�6�   $��Center=�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
dtBirthday��5      $	 230��6)   $	 388��6;   $��36��6L   $	��167��6X   $
��Left=�6d   $��Center=�6   $��18(�6�   �� 5   
   -   5         ��Name$ btnSave��5      $
��Save��6"   $	 230��61   $	 450��6C   $��38��6T   $��90��6`   $
��Left=�6k   $��Center=�6�   6�   �� 5   
   -	   5        $ btnClose��5      $��Close��6#   $	 504��63   $	 450��6E   $��38��6V   $��90��6b   $��Center=�6m   $	��Top=�6�   6�   5      5      