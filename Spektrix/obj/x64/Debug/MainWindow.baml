   M S B A M L   `   `   `  ����C  ?Spektrix, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:SpektrixSpektrix  5   	   9!clr-namespace:Spektrix.ComponentsSpektrix.Components  6.   3clr-namespace:Spektrix.WidgetsSpektrix.Widgets  6c       Spektrix.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Spektrix     5   	   8
components!clr-namespace:Spektrix.Components     6.   2widgetsclr-namespace:Spektrix.Widgets     6c   -   5          � WindowStyle$
  None=�5   	    � WindowState$ Normal=�5	   	    � WindowStartupLocation$ Manual=�5
   	   
 � Top$ 0��6(    � Left$ 0��60    � AllowsTransparency .  � Topmost .  � ShowInTaskbar .   � Title$ 
MainWindow��5   	   #��Z��5   	   #��Z��5   	   .��5      � -   5        	 �Name$	 MainGrid��5      
 � RowDefinitions
 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       �� 5!      �� 5"      �� 5#      �� 5$      �� 5&      �� 5'      �� 5(      �� 5)      �� 5*       � ColumnDefinitions 5-   
   �� 5.      �� 5/      �� 50      �� 51      �� 52      �� 54      �� 55      �� 56      �� 57      �� 58      �� 5:      �� 5;      �� 5<      �� 5=      �� 5>      �� 5@      �� 5A      �� 5B      �� 5C      �� 5D      �� 5F      .+�5I   
   � -   5        $	 exit_background��5I      
������ $��0��5K      $��20��6   $��0��5L      $��21��6   � 5N   
   $��1��6   $��3��6   $��6��5O      $��9��6   .+�5P      )   #Spektrix.Components.DateTimeDisplay  -   5          Name$ main_display_clock��5P   )   5Q      � 5S   
   -   5        $	 startup_bar��5S      $��0��6$   $��2��61   $��17��6A   .+�5T      �� -   5        
�������$��0,0,0,0q�5T   =   $	��0.1��6O   $��Stretch=�5U      $	��Top=�66   5V      � 5X   
   $��3��6   $��3��6   $��1��6-   $��19��6=   
 5Y      �� 5Z      �� 5[      �� 5\      �� 5]      .+�5_      !   Spektrix.Components.TabMenu  -   5          Name$ main_tab_bar��5_   !   $��1��5`   !   $��2��6.   5a         Spektrix.Components.Group  5f   
   -   5          Name$ 
main_group��5f      $��6��5g      $��8��6+   $��1��5h      $��19��6.   5k      5l      