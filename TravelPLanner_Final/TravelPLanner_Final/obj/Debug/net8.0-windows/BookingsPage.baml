   M S B A M L   `   `   `  ����  TravelPLanner_Final'    !TravelPlannerDesktop.BookingsPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        N� Title$  Bookings Page��5      .��5      � 
�������$��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5	      $
��Auto �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0,0,0,10q�6.   $��0��6@   .+�5      �� -   5        $��DestinationTextBox��5      $	��150��60   $��30��6<   $��5q�6H    � ToolTip$ Enter Destination��6S   (  "System.Windows.Controls.DatePicker  5      -   5        $��StartDatePicker��5      $	��150��60   $��5q�6<     5      -   5        $��EndDatePicker��5      $	��150��6.   $��5q�6:   �� 5      -   5        $��GuestsTextBox��5      $	��100��6+   $��30��67   $��5q�6C   $ Enter Guests��6N   �� 5      -   5        $��Add Booking��5      
������
�������$
��Bold"�6o   $	��100��6�   $��5q�6�   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��BookingDataGrid��5      $��1��6*      AutoGenerateColumns$ False��67      CanUserAddRows$ False��6S   $��	0,10,0,10q�6j      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Destination��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6Z   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6:   �� *Destination+6Z     5      $ 
Start Date��6%   $ * 6W   	 69   �� *	StartDate+6W     5      $ End Date��6%   $ * 6S   	 67   �� *	EndDate+6S     5      $ Guests��6%   $ * 6P   	 65   �� *Guests+6P   5      �� 5    
   $ 
Horizontal=�6   $��Right=�6.   $��2��6J   $��0,10,0,0q�6W   .+�5!      �� -   5        $��Update Booking��5!      
��� ���
�������$
��Bold"�6q   $	��120��6�   $��5q�6�   �� 5"      -   5        $��Delete Booking��5"      
���  ��
�������$
��Bold"�6n   $	��120��6�   $��5q�6�   5#      5$      5%      