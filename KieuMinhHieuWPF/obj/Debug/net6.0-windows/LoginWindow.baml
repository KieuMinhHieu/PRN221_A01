   M S B A M L   `   `   `  ����J  FKieuMinhHieuWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:KieuMinhHieuWPFKieuMinhHieuWPF  5   	   !    KieuMinhHieuWPF.LoginWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:KieuMinhHieuWPF     5   	   -   5          �Name$  	LoginPage��5   	    � Title$ LoginWindow��5   	   $	��400��6   $	��600��6*    � 
ResizeMode$ NoResize=�66   .��5
      �� .+�5   
   �� -   5         ��Name$ lbLogin��5      $��Login��6!    �� Left$ 31��61   
 �� Top$ 23��6B   $��24(�6R   $
��Bold"�6`   $
��Left=�6r   $	��Top=�6�   �� 5   
   -   5        $ lbEmail��5      $��Email��6!   $ 21��61   $ 95��6B   $��Center=�6R   $��20(�6m   $
��Left=�6{   �� 5   
   -   5        $ 
lbPassword��5      $��Password��6$   $ 21��67   $	 155��6H   $	��Top=�6Y   $��20(�6q   $��Center=�6   �� 5   
   -   5         ��Name$ txtEmail��5      $	 121��6$    �� TextWrapping$
 Wrap=�66   $ 98��6K   $	��444��6[   $
��Left=�6g   $��Center=�6�   $��34��6�   $��19(�6�   G� 5   
   -   5         G�Name$ txtPassword��5      $	 121��6+   $	 155��6=   $	��444��6N   $
��Left=�6Z   $��Center=�6u   $��34��6�   $��19(�6�   �� 5   
   -   5        	 ��Name$	 btnLogin��5      $��Login��6#   $	 157��63   $	 229��6E   $��41��6V   $	��109��6b   $
��Left=�6�   $��Center=�6�   �� 5   
   -   5        $	 btnClose��5      $��Close��6#   $	 379��63   $	 229��6E   $��41��6V   $	��108��6b   $
��Left=�6�   $��Center=�6�   �� 5   
   -	   5        
 ��Name$
 txtErrormessage��5       $��34��6   $	��Top=�6:   $	��248��6R    J� OpacityMask
 �<�����	#FFE5572C$	 121��6�   $ 59��6�   $��22(�6�   $��Center=�6�   5      5      