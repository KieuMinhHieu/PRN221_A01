   M S B A M L   `   `   `  ����J  FKieuMinhHieuWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:KieuMinhHieuWPF.AdminWindows.Customers&KieuMinhHieuWPF.AdminWindows.Customers  5   	   ;    5KieuMinhHieuWPF.AdminWindows.Customers.CustomerWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:KieuMinhHieuWPF.AdminWindows.Customers     5   	     � Title$  CustomerWindow��5   	   $	��450��6    $	��800��6-   .��5	      ]� .+�5   
   o� $	��Top=�6   $��29��6$   .@�5      m� $��_File��6   $��25��6&   $��18(�62   .@�5      m� $
��_New��6   m� 5      $��_Open��6   m� 5      $��_Save��6   �� 5      m� 5      -   5        $��_Logout��5      6,   5      m� 5      $��_Tool��6   $��25��6&   $��18(�62   .@�5      m� -   5        $��_FlowerBouquetManagement��5      6=   m� 5      -   5        $��_OderManagement��5      64   5      5      �� 5   
   .+�5      �� -   5         ��Name$ 	txtSearch��5       �� Left$	 489��6*    �� TextWrapping$
 Wrap=�6<   
 �� Top$ 10��6P   $	��288��6`   $��29��6l   $��16(�6x    J� RenderTransformOrigin$ 0.5,0.5&�6�   $
��Left=�6�   $��Center=�6�   �� 5      $��Search:��6   $	 415��6'   $ 10��69   $��29��6I   $
��Left=�6U   $	��Top=�6p   $��69��6�   $��16(�6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ dgvCustomer��5   �   $	��230��6   $	��800��6$      
IsReadOnly$
 True��60   $��Center=�6C   $ 44��6`   $	��Top=�6p      AutoGenerateColumns$ False��6�   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6)      Header$ Id��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *
CustomerId+  5      $
 * 6)   $ Email��63    6C   �� *Email+  5      $
 * 6)   $
 Name��63    6C   �� *CustomerName+  5       $
 * 6)   $
 City��63    6A   �� *City+  5!      $
 * 6)   $ Country��63    6E   �� *	Country+  5"      $
 * 6)   $ Password��63    6G   �� *
Password+  5#      $
 * 6)   $ Birthday��63    6E   �� *
Birthday+  5$      $
 * 6)   $ NumOfOrders��63    6H   �� *NumOfOrders+5'      �� 5(      -   5        $	��New��5(      $	 172��6#   $	 320��65   $��35��6F   $��76��6R   $
��Left=�6]   $��Center=�6x   6�   �� 5)      -   5        $��Update��5)      $	 362��6&   $	 320��68   $��35��6I   $��76��6U   $
��Left=�6`   $��Center=�6{   6�   �� 5*      -   5        $��Delete��5*      $	 568��6&   $	 320��68   $��35��6I   $��76��6U   $
��Left=�6`   $��Center=�6{   6�   5+      5.      5/      