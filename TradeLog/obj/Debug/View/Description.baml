   M S B A M L   `   `   `  ����C  ?TradeLog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:TradeLog.ViewTradeLog.View  5   	       TradeLog.View.Description   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:TradeLog.View     5   	     � Title$  Trade Napló��5   	   $	��500��6   $	��800��6*   $	��800��66   $	��500��6E   $	��800��6U   $	��500��6d    � 
ResizeMode$ NoResize=�6t    � WindowStartupLocation$ CenterScreen=�6�    � WindowStyle$
 None=�6�    � AllowsTransparency . 
������  � 	Resources 5         FocusVisual �� Property �� Value J� SnapsToDevicePixels	 �� StrokeDashArray  Button.Static.Background
 �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 

 CR_BTN �� 
TargetType �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName  TextBox.Static.Border  TextBox.MouseOver.Border  TextBox.Focus.Border 	 TB_CR-  'System.Windows.Input.KeyboardNavigation ��Name �� Triggers ]� 
Conditions �� Property �� Value��%�  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 &	 �    &	 �    &	 �    &	     7  7  7  �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $		 1 2R�6�   5      5      5      �� 5   
   $
 	#FFDDDDDD��6;   �� 5   
   $
 	#FF707070��67   �� 5   
   $
 	#FFBEE6FD��6>   �� 5   
   $
 	#FF3C7FB1��6:   �� 5   
   $
 	#FFC4E5F6��6<   �� 5   
   $
 	#FF2C628B��68   �� 5   
   $
 	#FFF4F4F4��6=   �� 5   
   $
 	#FFADB2B5��69   �� 5   
   $
 	#FF838383��6=   �� 5    
   " ��6   .�5!      ��  �@�FocusVisualStyle8   61   �� 5"       � ��8  6+   �� 5#       � ��8  6,   �� 5$       � ��# � ��6+   �� 5%       � ��$ 1q�60   �� 5&       � ��$ Center=�6;   �� 5'       � ��$ Center=�69   �� 5(       � ��$ 1q�6(   �� 5)       � �� 5*      �� 5+      " ��6&   .R�5,      �� $ border��6!   $ 7��61   #��z��6B   $��0q�6n   #��z��6�    . ._�5-      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5.       5/      P� 50       �@��IsDefaulted . . �51   "   �� $ border��6@   # � ��6T    � ��52      P� 53       �@J�IsMouseOver . . �54   "   �� $ border��6?   8   � ��6S   �� 55   "   $ border��6@   8   � ��6T   56      P� 57       � �� . . �58   "   �� $ border��6?   8   � ��6S   �� 59   "   $ border��6@   8   � ��6T   5:      P� 5;       � {� .  . �5<   "   �� $ border��6?   8   � ��6S   �� 5=   "   $ border��6@   8   � ��6T   �� 5>   "   $ contentPresenter��6K   8 	  � ��6i   5?      5A      5C      5D      �� 5E   
   $
 	#FFABAdB3��68   �� 5F   
   $
 	#FF7EB4EA��6;   �� 5G   
   $
 	#FF569DE5��67   �� 5H   
   " ��6   .�5I      ��  � ��# � ��6+   �� 5J       � ��8   6,   �� 5K       � ��# � ��6+   �� 5L       � ��$ 1q�60   �� 5M       �@ TabNavigation$
 None=�6A   �� 5N       � ��$
 Left=�6;   �� 5O       �@�FocusVisualStyle 61   Z� �� 5P       �@J�	AllowDrop . 6*   �� 5Q       �@��PanningMode$ VerticalFirst=�69   �� 5R       �@��IsFlicksEnabled .  67   �� 5S       � �� 5T      �� 5U      " ��6&   .R�5V      �� $ border��6!   $ 10��61   #��z��6C   #��z��6o   #��z��6�    . ._�5W      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5X       5Y      P� 5Z       � {� .  . �5[   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5\      P� 5]       �@J�IsMouseOver . . �5^   "   �� $ border��6@   8   � ��6T   5_      P� 5`       �@J�IsKeyboardFocused . . �5a   "   �� $ border��6@   8   � ��6T   5b      5d      5f       5g      ]� 5h       5i      �� 5j      + �@��#IsInactiveSelectionHighlightEnabled . 6S   �� 5k       �@��IsSelectionActive .  6A   ./�5m      ��  �@��SelectionBrush# � /�67   5n      5p      5r      .��5v      � .+�5w   
   �� 
�������
�������$��2��64   $	��500��6H   $	��800��6U   $	��800��6a   $	��500��6p   $	��800��6�   $	��500��6�   5y      �� 5z   
   -   5         ��Name$ 
megjegyzes��5z      $��Center=�6'   $��Center=�6D   
�������$	��780��6r   $	��430��6~   $��10,10,10,60q�6�   #���  6�    �� TextWrapping$
 Wrap=�6�   " �� VerticalScrollBarVisibility$ Hidden=�6�    �� AcceptsReturn . 6�   �� 5|      -   5         ��Name$ Mentes��5|      $��Mentés��6%   $��Right=�66   $��	0,0,14,17q�6R   $��Bottom=�6e   $��75��6�   $��30��6�   #��� 
 6�   $��Bahnschrift Light)�6�   $��15(�6�   6�   �� 5}      -   5        $ Megse��5}      $��Mégse��6$   $��Right=�64   $��
0,0,114,17q�6P   $��Bottom=�6d   $��75��6   $��30��6�   #��� 
 6�   $��Bahnschrift Light)�6�   $��15(�6�   6�   5�      5�      