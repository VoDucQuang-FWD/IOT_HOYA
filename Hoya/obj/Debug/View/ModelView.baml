   M S B A M L   `   `   `  ����?  ;Hoya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Hoya.View	Hoya.View  5   	       Hoya.View.ModelView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v19.2, Version=19.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Hoya.View     5   	   c _DevExpress.Xpf.Charts.v19.2, Version=19.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxc4http://schemas.devexpress.com/winfx/2008/xaml/charts  5   	     � WindowStartupLocation$  Manual=�5	   	      DBHoya1 � DataContext# [  5
   	    � Title$ 	ModelView��5   	   $	��450��6   $
��1500��6(   .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   � $��0��6    � RowDefinitions 5      �� 5      $
��0.1* �6    60   �� 5      6"   .+�5      �� $��Model 1��6   $��20(�6'   $
��Bold"�65   
���   �$��Center=�6Z   $��Center=�6w   6�   � 5      $��1��6   .+�5      (  "DevExpress.Xpf.Charts.ChartControl  
������ 
������ $��0q�6W      ToolTipEnabled$
 TrueX�5   1      AnimationMode$ OnDataChanged=�6G     palette,  &DevExpress.Xpf.Charts.ChartControlBase   Palette# [ 6e      Legends 5      "  DevExpress.Xpf.Charts.Legend  5      	   HorizontalPosition$	 Center=�6%   
   VerticalPosition$
 BottomOutside=�5   F      Orientation$ 
Horizontal=�5    D      ReverseItems . (  "DevExpress.Xpf.Charts.ChartElement   Height$ 25Q�5"   E   $��20(�5#   F   $��0q�5$   F      Diagram. 5&      +  %DevExpress.Xpf.Charts.SimpleDiagram2D  #  DevExpress.Xpf.Charts.Diagram   Series. 5'      '  !DevExpress.Xpf.Charts.PieSeries2D  # [  5)   :   "  DevExpress.Xpf.Charts.Series   ArgumentDataMember$ Argument��5*   :      ValueDataMember$ Value��5+   :      LabelsVisibility .    LegendTextPattern$ {A}: {V}��5-   :   %	  DevExpress.Xpf.Charts.PieSeries 	  HoleRadiusPercent$ 50Q�5.   :      
DataSource 5(   :   �� *ProgressModel1Shift+   Model 50      +
  %DevExpress.Xpf.Charts.GlarePie2DModel
  51   "      Label 54      '  !DevExpress.Xpf.Charts.SeriesLabel  55   "      TextPattern$ {VP:P}��62    	  LabelPosition$ 
TwoColumns=�56   2   58      59      5:      �� 5<      $��30(�66   $��Center=�6D   $��Center=�6a   $��0,0,0,38q�6|   ��6   �� *	QtyModel1+6�   5>      5?      � 5@   
   $��1��6    5A      �� 5B      $
��0.1* �6    60   �� 5C      6"   .+�5E      �� $��Model 2��6   $
��Bold"�6'   
���   �$��Center=�6L   $��Center=�6i   $��20(�6�   6�   � 5F      $��1��6   .+�5G        
������ 
������ $��0q�6W   $
 TrueX�5H   1   $ OnDataChanged=�6G   # [ 6e    5I        5J      $	 Center=�6%   $
 BottomOutside=�5K   F   $ 
Horizontal=�5L   D    . $ 25Q�5N   E   $��20(�5O   F   $��0q�5P   F   . 5R        . 5S        # [  5U   :   $ Argument��5V   :   $ Value��5W   :    . $ {A}: {V}��5Y   :   $ 50Q�5Z   :    5T   :   �� *ProgressModel2Shift+ 5\      
  5]   "    5`        5a   "   $ {VP:P}��62   $ 
TwoColumns=�5b   2   5d      5e      5f      �� 5h      $��30(�66   $��Center=�6D   $��Center=�6a   $��0,0,0,38q�6|   ��6   �� *	QtyModel2+6�   5j      5k      � 5l   
   $��2��6    5m      �� 5n      $
��0.1* �6    60   �� 5o      6"   .+�5q      �� $��Model 3��6   $
��Bold"�6'   
���   �$��Center=�6L   $��Center=�6i   $��20(�6�   6�   � 5r      $��1��6   .+�5s        
������ 
������ $��0q�6W   $
 TrueX�5t   1   $ OnDataChanged=�6G   # [ 6e    5u        5v      $	 Center=�6%   $
 BottomOutside=�5w   F   $ 
Horizontal=�5x   D    . $ 25Q�5z   E   $��20(�5{   F   $��0q�5|   F   . 5~        . 5        # [  5�   :   $ Argument��5�   :   $ Value��5�   :    . $ {A}: {V}��5�   :   $ 50Q�5�   :    5�   :   �� *ProgressModel3Shift+ 5�      
  5�   "    5�        5�   "   $ {VP:P}��62   $ 
TwoColumns=�5�   2   5�      5�      5�      �� 5�      $��30(�66   $��Center=�6D   $��Center=�6a   $��0,0,0,38q�6|   ��6   �� *	QtyModel3+6�   5�      5�      � 5�   
   $��3��6    5�      �� 5�      $
��0.1* �6    60   �� 5�      6"   .+�5�      �� $��Model 4��6   $
��Bold"�6'   
���   �$��Center=�6L   $��Center=�6i   $��20(�6�   6�   � 5�      $��1��6   .+�5�        
������ 
������ $��0q�6W   $
 TrueX�5�   1   $ OnDataChanged=�6G   # [ 6e    5�        5�      $	 Center=�6%   $
 BottomOutside=�5�   F   $ 
Horizontal=�5�   D    . $ 25Q�5�   E   $��20(�5�   F   $��0q�5�   F   . 5�        . 5�        # [  5�   :   $ Argument��5�   :   $ Value��5�   :    . $ {A}: {V}��5�   :   $ 50Q�5�   :    5�   :   �� *ProgressModel4Shift+ 5�      
  5�   "    5�        5�   "   $ {VP:P}��62   $ 
TwoColumns=�5�   2   5�      5�      5�      �� 5�      $��30(�66   $��Center=�6D   $��Center=�6a   $��0,0,0,38q�6|   ��6   �� *	QtyModel4+6�   5�      5�      5�      5�      