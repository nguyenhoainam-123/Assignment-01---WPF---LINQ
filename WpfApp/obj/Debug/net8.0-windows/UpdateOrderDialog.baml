   M S B A M L   `   `   `  ����
  WpfApp    WpfApp.OrderUpdateDialog   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Update Order��5   	   $	��340��5   	   $	��420��6    � WindowStartupLocation$ CenterOwner=�5   	    � 
ResizeMode$ NoResize=�5   	   ���#f0f4f8.��5
      � $��0,0,0,55q�6    � RowDefinitions 5   
   �� 5      $
��268* �6   �� 5      $	��13* �6   �� 5      $��4* �6    � ColumnDefinitions 5   
   �� 5      $��9* �6   �� 5      $	��88* �6   �� 5      $
��323* �6   .+�5   
   �� 
������� �� CornerRadius$ 10��5       �� Padding$ 20q�5      $	��380��5      $
��Left=�5      $��Bottom=�5      $	��323��6,   $��2��69   $��
11,0,0,-38q�6M   $��3��6a   $��1��6r   ._�5      �� .+�5      �� $��Update Order��6   $��18(�5      $
��Bold"�5      ���#2c3e50$��Center=�5!      $��0,0,0,15q�5"      �� 5$       �� Orientation$ 
Horizontal=�6   $	��0,5q�66   .+�5%      �� $��	Order ID:��6   $	��120��60   $��Center=�6<   �� 5&      -   5         ��Name$ 
txtOrderID��5&      $	��200��5'      	 �� 
IsReadOnly$
	 True��5(      ���#e0e0e0���#5555*      5+      �� 5-      $ 
Horizontal=�6   $	��0,5q�66   .+�5.      �� $��Customer ID:��6   $	��120��63   $��Center=�6?   �� 5/      -   5        $ txtCustomerID��5/      $	��200��65   50      �� 52      $ 
Horizontal=�6   $	��0,5q�66   .+�53      �� $��Employee ID:��6   $	��120��63   $��Center=�6?   �� 54      -   5        $ txtEmployeeID��54      $	��200��65   55      �� 57      $ 
Horizontal=�6   $	��0,5q�66   .+�58      �� $��Order Date:��6   $	��120��62   $��Center=�6>   (  "System.Windows.Controls.DatePicker  59      -   5        
  Name$
 dpOrderDate��59   !   $	��200��66   5:      �� 5<      $ 
Horizontal=�6   $��Center=�5=      $��0,30,0,0q�5>      .+�5?      �� -   5         ��Name$ 	btnUpdate��5?      $��Update��5@      $	��110��5A      $��38��5B      $��0,0,20,0q�5C      ���#2980b9
�������$
��Bold"�5F      5G      �� 5I      -   5        $ 	btnCancel��5I      $��Cancel��5J      $	��110��5K      $��38��5L      ���#c0392b
�������$
��Bold"�5O      5P      5Q      5R      5S      5T      5U      