   M S B A M L   `   `   `  ����J  FVuHuongTrangWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:VuHuongTrangWPF.AdminWindowsVuHuongTrangWPF.AdminWindows  5   	   3    -VuHuongTrangWPF.AdminWindows.DetailManagement   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:VuHuongTrangWPF.AdminWindows     5   	     � Title$  DetailManagement��5   	   $	��500��6"   $	��800��6/    � Cursor$ AppStarting��6;    � WindowStartupLocation$ CenterScreen=�6P    � 
ResizeMode$ NoResize=�6u   .��5	      � -   5        ��5
   
   �� 5       �� 
StartPoint$	 0,1&�6"    �� EndPoint$	 1,0&�63   .��5      �  � Color$ #060531��6    � Offset$ 0Q�6/   � 5      $ #333238��6   $ 1Q�6/   5       � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��30 �6   	 � ColumnDefinitions	 5   
   �� 5      $��119.415 �6   �� 5      $��30.585 �6   �� 5      $	��11* �6   �� 5      $	��11* �6   �� 5      $	��96* �6   �� 5       $	��12* �6   .+�5"   
   �� -   5        
 ��Name$
 lbTitle��5"      $��Customer Management��6!   $��3��6?   $��0��6O   $��36(�6\   $��2��6j   $
��Left=�6~   $	��466��6�   
�������$��37,0,0,0q�6�   &   System.Windows.Controls.DataGrid  5#   
   -   5          Name$ dgData��5#      $��	4,16,4,97q�6#   $��2��66   $��1��6F   $��4��5$      $��6��6F   �� 5%   
   -   5         ��Name$ btnCustomer��5%      $��	Customers��6&   $
��Left=�6:   $��2��6U   $��1��6f   $��Center=�6s   $	��154��6�   $��3��6�   $��28��6�   6�   �� 5&   
   -   5        $ 
btnBooking��5&      $��Bookings��6%   $
��Left=�68   $��3��6S   $	��Top=�6`   $	��154��6x   $��3��6�   $��30��6�   $��0,13,0,0q�6�   $��2��6�   �� 5'   
   -   5        $ btnRoom��5'      $��Rooms��6"   $
��Left=�62   $��2��6M   $��2��6^   $	��Top=�6k   $	��154��6�   $��3��6�   $��30��6�   $��0,14,0,0q�6�   �� 5(   
   -   5        $ 	btnCreate��5(      $��Create��6$   $
��Left=�65   $��
0,168,0,25q�6P   $��6��6d   $	��100��6q   ���	#FF00C81A
�������
�������$��2��6�   $��2��6�   $��2��6�   �� 5)   
   -   5        $ 	btnReport��5)      $��Report��6$   $��24,168,356,25q�65   $��6��6L   ���#FFFF00$	��100��6n   
�������
�������$��2��6�   $��4��6�   �� 5*   
   -	   5        $ 	btnUpdate��5*      $��Update��6$   $
��Left=�65   $��153,168,0,25q�6P   $��6��6f   $	��100��6s   ���	#FFC86500
�������
�������$��4��6�   $��2��6�    J� RenderTransformOrigin$ 0.975,0.509&�6�   �� 5+   
   -
   5        $ 	btnDelete��5+      $��Delete��6$   $
��Left=�65   $��286,168,0,25q�6P   $��6��6f   $	��100��6s   ���	#FFC81D00
�������
�������$��4��6�   $��2��6�   $ 0.637,0.661&�6�   �� 5,   
   -   5        $ btnClose��5,      $��Close��6#   $��4��63   $
��Left=�6C   $��410,168,0,25q�6^   $��6��6t   $	��100��6�   ���	#FFEF8F18
�������$��2��6�   $��2��6�   (  "System.Windows.Controls.DatePicker  5-   
   -   5          Name$ dpStartDate��5-      $��2��6*   $
��Left=�6:   $��	4,123,0,0q�6U   $��6��6h   $	��Top=�6u   $��26��6�   $	��321��6�   $��3��6�     5.   
   -   5        $ 	dpEndDate��5.      $��4��6(   $
��Left=�68   $��242,123,0,0q�6S   $��6��6h   $	��Top=�6u   $��26��6�   $	��288��6�   $��2��6�   �� 5/   
   -   5        $
 lbStartDate��5/      $��2��6%   $��
Start Date��65   $
��Left=�6J   $��6,98,0,0q�6e   $��6��6w   $	��Top=�6�   $ -0.009,0.834&�6�   
�������$��2��6�   $��81��6�   �� 50   
   -   5        $
 	lbEndDate��50      $��4��6#   $��End Date��63   $
��Left=�6F   $��
242,98,0,0q�6a   $��6��6u   $	��Top=�6�   $ -0.009,0.834&�6�   
�������$��81��6�   � 51   
   -   5        $��CustomerPopUp��51      $��Center=�6%    � 	StaysOpen$ False��68    � AllowsTransparency$
 True��6J   .��52      �� 
�������
���   �$��1q�6<    �� Padding$ 10q�6P   ._�53      �� .+�54      �� $��Enter Information:��6    $��0,0,0,10q�6:   $
��Bold"�6L   �� 56       �� Orientation$ 
Horizontal=�6!   $��0,5,0,5q�6:   .+�57      �� $	��ID:��6$   $	��100��6/   $��Center=�6;   �� 58      -   5         ��Name$ 	IDTextBox��58   "   $	��200��65   ${�False��6A   59      �� 5;      $ 
Horizontal=�6!   $��0,5,0,5q�6:   .+�5<      �� $��Name:��6$   $	��100��61   $��Center=�6=   �� 5=      -   5        $ NameTextBox��5=   "   $	��200��67   5>      �� 5@      $ 
Horizontal=�6!   $��0,5,0,5q�6:   .+�5A      �� $��Email:��6$   $	��100��62   $��Center=�6>   �� 5B      -   5        $ EmailTextBox��5B   "   $	��200��68   5C      �� 5D      $ 
Horizontal=�6!   $��0,5,0,5q�6:   .+�5E      �� $��Address:��6$   $	��100��64   $��Center=�6@   �� 5F      -   5        $ AddressTextBox��5F   "   $	��200��6:   5G      �� 5H      $ 
Horizontal=�6!   $��0,5,0,5q�6:   .+�5I      �� $��Phone:��6$   $	��100��62   $��Center=�6>   �� 5J      -   5        $ PhoneTextBox��5J   "   $	��200��68   5K      �� 5M      $ 
Horizontal=�6!   $��0,5,0,5q�6:   .+�5N      �� $��	Password:��6$   $	��100��65   $��Center=�6A   �� 5O      -   5        $ PasswordBox��5O   "   $	��200��67   5P      �� 5R      $ 
Horizontal=�6!   $��0,5,0,5q�6:   .+�5S      �� $��
BirthDate:��6$   $	��100��66   $��Center=�6B     5T      -   5        $ BirthDatePicker��5T   %   $	��200��6>   5U      �� 5W      $ 
Horizontal=�6!   $��Right=�6:   $��0,10,0,0q�6V   .+�5X      �� -   5        $��OK��5X   !   $��75��6S   $��0,0,5,0q�6^   �� 5Y      -   5        $��Cancel��5Y   !   $��75��6[   5Z      5[      5\      5]      � 5^   
   -   5        $��	RoomPopup��5^      $��Center=�6!   $ False��64   $
 True��6F   .��5_      �� 
�������
���   �$��1q�6<   $ 10q�6P   ._�5`      �� .+�5a      �� $��Nhập thông tin phòng:��6    $��0,0,0,10q�6=   $
��Bold"�6O   �� 5c      $ 
Horizontal=�6!   $��0,5,0,5q�6:   .+�5d      �� $��Số phòng:��6$   $	��100��65   $��Center=�6A   �� 5e      -   5        $ RoomNumberTextBox��5e   "   $	��200��6=   5f      �� 5h      $ 
Horizontal=�6!   $��0,5,0,5q�6:   .+�5i      �� $��	Mô tả:��6$   $	��100��62   $��Center=�6>   �� 5j      -   5        $ RoomDescriptionTextBox��5j   "   $	��200��6B   5k      �� 5m      $ 
Horizontal=�6!   $��0,5,0,5q�6:   .+�5n      �� $��Sức chứa tối đa:��6$   $	��100��6<   $��Center=�6H   �� 5o      -   5        $ MaxCapacityTextBox��5o   "   $	��200��6>   5p      �� 5r      $ 
Horizontal=�6!   $��0,5,0,5q�6:   .+�5s      �� $��Trạng thái:��6$   $	��100��67   $��Center=�6C   �� 5t      -   5         ��Name$ StatusComboBox��5t   #   $	��200��6;   .@�5u      �� $��Đang sử dụng��6+   �� 5v      $��Không sử dụng��6+   5w      5x      �� 5z      $ 
Horizontal=�6!   $��0,5,0,5q�6:   .+�5{      �� $��Giá mỗi ngày:��6$   $	��100��69   $��Center=�6E   �� 5|      -   5        $ PriceTextBox��5|   "   $	��200��68   5}      �� 5      $ 
Horizontal=�6!   $��0,5,0,5q�6:   .+�5�      �� $��Loại phòng:��6$   $	��100��67   $��Center=�6C   �� 5�      -    5        $ RoomTypeTextBox��5�   "   $	��200��6;   5�      �� 5�      $ 
Horizontal=�6!   $��Right=�6:   $��0,10,0,0q�6V   .+�5�      �� -!   5        $��OK��5�   !   $��75��6S   $��0,0,5,0q�6^   �� 5�      -"   5        $��Cancel��5�   !   $��75��6Q   5�      5�      5�      5�      5�      5�      