   M S B A M L   `   `   `  ����J  FKieuMinhHieuWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:KieuMinhHieuWPF.AdminWindows.Customers&KieuMinhHieuWPF.AdminWindows.Customers  5   	   A    ;KieuMinhHieuWPF.AdminWindows.Customers.UpdateCustomerWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:KieuMinhHieuWPF.AdminWindows.Customers     5   	     � Title$  UpdateCustomerWindow��5   	   $	��550��6&   $	��800��63   .��5	      �� .+�5
   
   �� $��Update Customer��6   
 �� Top$ 8��6+    �� Left$ 66��6:   $
��Left=�6K   $	��Top=�6f   $	��224��6~   $��43��6�   $��26(�6�   $
��Bold"�6�   �� 5   
   $��Email��6   $ 61��6    $
��Left=�62   $	��Top=�6M   $��36��6e   $��90��6q   $��18(�6|   $	 176��6�   �� 5   
   $
��Name��6   $	 131��6   $ 61��61   $
��Left=�6C   $	��Top=�6^   $��36��6v   $��90��6�   $��18(�6�   �� 5   
   $
��City��6   $ 61��6   $
��Left=�61   $	��Top=�6L   $��36��6d   $��90��6p   $��18(�6{   $	 230��6�   �� 5   
   $��Country��6   $ 61��6"   $
��Left=�64   $	��Top=�6O   $��36��6g   $��90��6s   $��18(�6~   $	 284��6�   �� 5   
   $��Password��6   $ 61��6#   $
��Left=�65   $	��Top=�6P   $��36��6h   $��90��6t   $��18(�6   $	 338��6�   �� 5   
   $��Birthday��6   $ 64��6#   $
��Left=�65   $	��Top=�6P   $��36��6h   $��90��6t   $��18(�6   $	 397��6�   �� 5   
   -   5         ��Name$ txtName��5      $	 231��6#    �� TextWrapping$
 Wrap=�65   $	 131��6J   $	��429��6[   $��36��6g   $��18(�6s   $
��Left=�6�   $	��Top=�6�   $��Center=�6�   �� 5   
   -   5        $ txtEmail��5      $	 231��6$   $
 Wrap=�66   $	 176��6K   $	��429��6]   $��36��6i   $��18(�6u   $
��Left=�6�   $	��Top=�6�   $��Center=�6�   �� 5   
   -   5        $ txtCity��5      $	 231��6#   $
 Wrap=�65   $	 230��6J   $	��429��6\   $��36��6h   $��18(�6t   $
��Left=�6�   $	��Top=�6�   $��Center=�6�   �� 5   
   -   5        $ 
txtCountry��5      $	 231��6&   $
 Wrap=�68   $	 284��6M   $	��429��6_   $��36��6k   $��18(�6w   $
��Left=�6�   $	��Top=�6�   $��Center=�6�   G� 5   
   -   5         G�Name$ txtPassword��5      ${�False��6+   $	 231��6=   $	 338��6O   $	��429��6a   $��36��6m   $��18(�6y   $
��Left=�6�   $	��Top=�6�   $��Center=�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
dtBirthday��5      $	 234��6)   $	 401��6;   $��36��6L   $	��167��6X   $
��Left=�6d   $	��Top=�6   $��18(�6�   �� 5   
   -   5         ��Name$ 	btnUpdate��5      $��Update��6$   $	 234��65   $	 463��6G   $��38��6X   $��90��6d   $
��Left=�6o   $	��Top=�6�   6�   �� 5   
   -   5        $ btnClose��5      $��Close��6#   $	 508��63   $	 463��6E   $��38��6V   $��90��6b   $
��Left=�6m   $	��Top=�6�   6�   �� 5   
   $��Id��6   $ 75��6   $ 61��6.   $��36��6?   $��90��6K   $��18(�6V   $��Center=�6d   $	��Top=�6�   �� 5   
   -	   5        $ txtId��5      $	 231��6!   ${�False��63   $
 Wrap=�6E   $ 75��6Z   $	��429��6j   $��36��6v   $��18(�6�   $��Center=�6�   $��Center=�6�   $	��Top=�6�   5      5      