   M S B A M L   `   `   `  ���� C  ?TradeLog, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:TradeLog.ViewTradeLog.View  b ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes /clr-namespace:TradeLog.ModelTradeLog.Model      TradeLog.View.LogView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:TradeLog.View     ^ThemesKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2     /modelsclr-namespace:TradeLog.Model       � Title$  Trade Napló��$	��750��$
��1300��$
��1300��$	��750��$
��1300��$	��750�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency . 
������  � Icon$* $/TradeLog;component/Resource/tax.png�� � 	Resources    FocusVisual �� Property �� Value	 J� SnapsToDevicePixels
 �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 

 clsbtn �� 
TargetType �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName  TextBox.Static.Border  TextBox.MouseOver.Border  TextBox.Focus.Border  tb_r-  'System.Windows.Input.KeyboardNavigation �� CornerRadius ��Name �� Triggers ]� 
Conditions �� Property �� Value  felvitelitb  ComboBox.Static.Background �� EndPoint �� 
StartPoint � Color � Offset  ComboBox.Static.Border ' #ComboBox.Static.Editable.Background # ComboBox.Static.Editable.Border . *ComboBox.Static.Editable.Button.Background * &ComboBox.Static.Editable.Button.Border  ComboBox.MouseOver.Glyph ! ComboBox.MouseOver.Background  ComboBox.MouseOver.Border * &ComboBox.MouseOver.Editable.Background & "ComboBox.MouseOver.Editable.Border 1 -ComboBox.MouseOver.Editable.Button.Background - )ComboBox.MouseOver.Editable.Button.Border  ComboBox.Pressed.Glyph  ComboBox.Pressed.Background  ComboBox.Pressed.Border (  $ComboBox.Pressed.Editable.Background $!  ComboBox.Pressed.Editable.Border /" +ComboBox.Pressed.Editable.Button.Background +# 'ComboBox.Pressed.Editable.Button.Border $ ComboBox.Disabled.Glyph  % ComboBox.Disabled.Background & ComboBox.Disabled.Border )' %ComboBox.Disabled.Editable.Background %( !ComboBox.Disabled.Editable.Border 0) ,ComboBox.Disabled.Editable.Button.Background ,* (ComboBox.Disabled.Editable.Button.Border + ComboBox.Static.Glyph , ComboBoxToggleButton F�Name ^� 
Conditions  �� Binding! �� RelativeSource" �� AncestorType - ComboBoxTemplate# �Name$ � ColumnDefinitions% �Name& � AllowsTransparency' �� Mode5  /Microsoft.Windows.Themes.SystemDropShadowChrome(  Name)   Color* �� MaxDropDownHeight+ �� ElementName, �� ClearTypeHint- ��Name. ��Name/ �� RadiusX0 �� RadiusY1 ��Name2   DirectionalNavigation3 d�Name4 d� 	IsChecked5 �� SelectionBoxItemTemplate6 �� SelectionBoxItem#7 �� SelectionBoxItemStringFormat8 �� ContentStringFormat9 J� IsHitTestVisible: P� 
SourceName . TextBox.Static.Background / ComboBoxEditableTextBox 0 ComboBoxEditableTemplate; ��Name< �� 
IsReadOnly 1 CNRadius 2 	FelvetBTN 3 ListBox.Static.Background 4 ListBox.Static.Border 5 ListBox.Disabled.Background 6 ListBox.Disabled.Border 
7 lb1_cr= �� Padding��%�.  &	        &	 N     &	 c     &	 x     &	 �     &	 �     &	 �     &	 �     &	 �     &		 �     &	
     7   7  7  7  7  7  7 	 &	 �    &	 �    &	 �    &	 �    7  7  7  &	 �    7  7  7  &	 
    &	 j
    &	 
    &	 �
    &	 �
    &	 �
    &	 �
    &	 �
    &	 F    &	 [    &	 p    &	 �    &	 �    &	 �    &	 	    &	 c    &	  x    &	! �    &	" �    &	# �    &	$     &	% &    &	& ;    &	' P    &	( e    &	) z    &	* �    &	+ �    &	, �    7  7  7 + 7  7  7  7  7  7  7  7  7  7  7  7  7  7  7   7 ! 7 " 7 # 7 $ 7 % 7 & 7 ' 7 ( 7 ) 7 * &	- �    7 , &	. �    &	/ �    &	0 @    7 , 7 . 7 / &	1 �$    7   7  7  7 - 7 0 &	2 G&    7   7  7  7  7  7  7  7  7  7 	 &	3 ')    &	4 <)    &	5 Q)    &	6 f)    &	7 {)    7 3 7 4 7 5 7 6 �� .���  � �� �� .R��� $��2q�	 . #��� ��$��1��$	
 1 2R��� $ 	#FFDDDDDD���� $ 	#FF707070���� $ 	#FFBEE6FD���� $ 	#FF3C7FB1���� $ 	#FFC4E5F6���� $ 	#FF2C628B���� $ 	#FFF4F4F4���� $ 	#FFADB2B5���� $ 	#FF838383���� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $ border��#��z��#��z��#��z��	 . ._��� $ contentPresenter��|�.  #��z��#��z����. #	 z	 #��z�� P�  �@��IsDefaulted . . ��� $ border��# � �� � ��P�  �@J�IsMouseOver . . ��� $ border��8   � ��P�  � �� . P�  � {� .  . ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8   � ���� $ 	#FFABAdB3���� $ 	#FF7EB4EA���� $ 	#FF569DE5���� " ��.���  � ��# � ����  � ��8   ��  � ��# � ����  � ��$ 1q���  �@ TabNavigation$
 None=���  � ��$
 Left=���  �@�FocusVisualStyle Z� ��  �@J�	AllowDrop . ��  �@��PanningMode$ VerticalFirst=���  �@��IsFlicksEnabled .  ��  � �� �� " ��.R��� $ border��$ 10��#��z��#��z��#��z��	 . ._��� $ PART_ContentHost��|�.  $��Hidden=�$��Hidden=� P�  � {� .  . ��� $ border�� �@J�Opacity$
 0.56Q�P�  �@J�IsMouseOver . . ��� $ border��8   � ��P�  �@J�IsKeyboardFocused . . ��� $ border��8   � �� ]�  �� + �@��#IsInactiveSelectionHighlightEnabled . ��  �@��IsSelectionActive .  ./���  �@��SelectionBrush# � /��� " ��.���  � ��# � ����  � ��8   ��  � ��# � ����  � ��$ 1q���  �@ TabNavigation$
 None=���  � ��$
 Left=���  �@�FocusVisualStyle Z� ��  �@J�	AllowDrop . ��  �@��PanningMode$ VerticalFirst=���  �@��IsFlicksEnabled .  ��  � �� �� " ��.R��� $ border��$ 5��#��z��#��z��#��z��	 . ._��� $ PART_ContentHost��|�.  $��Hidden=�$��Hidden=� P�  � {� .  . ��� $ border�� �@J�Opacity$
 0.56Q�P�  �@J�IsMouseOver . . ��� $ border��8   � ��P�  �@J�IsKeyboardFocused . . ��� $ border��8   � �� ]�  �� + �@��#IsInactiveSelectionHighlightEnabled . ��  �@��IsSelectionActive .  ./���  �@��SelectionBrush# � /��� $	 0,1&�$	 0,0&�.��� $ 	#FFF0F0F0��$	 0.0Q�� $ 	#FFE5E5E5��$	 1.0Q��� $ 	#FFACACAC���� $ 	#FFFFFFFF���� $ 	#FFABADB3���� $ Transparent���� $ Transparent���� $ 	#FF000000���� $	 0,1&�$	 0,0&�.��� $ 	#FFECF4FC��$	 0.0Q�� $ 	#FFDCECFC��$	 1.0Q��� $ 	#FF7EB4EA���� $ 	#FFFFFFFF���� $ 	#FF7EB4EA���� $	 0,1&�$	 0,0&�.��� $ 	#FFEBF4FC��$	 0.0Q�� $ 	#FFDCECFC��$	 1.0Q��� $ 	#FF7EB4EA���� $ 	#FF000000���� $	 0,1&�$	 0,0&�.��� $ 	#FFDAECFC��$	 0.0Q�� $ 	#FFC4E0FC��$	 1.0Q��� $ 	#FF569DE5���� $ 	#FFFFFFFF���� $ 	#FF569DE5���� $	 0,1&�$	 0,0&�.��� $ 	#FFDAEBFC��$	 0.0Q�� $ 	#FFC4E0FC��$	 1.0Q��� $ 	#FF569DE5���� $ 	#FFBFBFBF���� $ 	#FFF0F0F0���� $ 	#FFD9D9D9���� $ 	#FFFFFFFF���� $ 	#FFBFBFBF���� $ Transparent���� $ Transparent���� $ 	#FF606060���� " d�.���  �@�OverridesDefaultStyle . ��  � �� .  ��  � |� .  ��  �@��	ClickMode$ Press=���  � �� �� " d�.R��� $ templateRoot��	 . 8��  #��z��8�� ._��� $ splitBorder��#��� r�	 . $��0q�$��Right=�$��1q�
������ ._�F� $ arrow��$��Center=�$��0q�$��Center=�8�� F����        ���( ��( јaQ     јaQ P����̰( � �    P����         ^�  ��   �� *
IsEditable+! �� "" �� true��   �� *IsMouseOver+! �� *Self+	 false��   �� *	IsPressed+! �� *Self+	 false��   �� *	IsEnabled+! �� *Self+ true.0��� $ templateRoot��8   � ���� $ templateRoot��8   � ���� $ splitBorder��8   � ���� $ splitBorder��8   � ��P�  �@J�IsMouseOver . . ��� $ arrow��8   � ��^�  ��   �� *IsMouseOver+! �� *Self+ true��   �� *
IsEditable+! �� "" ��	 false.0��� $ templateRoot��8   � ���� $ templateRoot��8 	  � ��^�  ��   �� *IsMouseOver+! �� *Self+ true��   �� *
IsEditable+! �� "" �� true.0��� $ templateRoot��8 
  � ���� $ templateRoot��8   � ���� $ splitBorder��8   � ���� $ splitBorder��8   � ��P�  � �� . . ��� $ arrow��8   � ��^�  ��   �� *	IsPressed+! �� *Self+ true��   �� *
IsEditable+! �� "" ��	 false.0��� $ templateRoot��8   � ���� $ templateRoot��8   � ��^�  ��   �� *	IsPressed+! �� *Self+ true��   �� *
IsEditable+! �� "" �� true.0��� $ templateRoot��8   � ���� $ templateRoot��8   � ���� $ splitBorder��8   � ���� $ splitBorder��8   � ��P�  � {� .  . ��� $ arrow��8   � ��^�  ��   �� *	IsEnabled+! �� *Self+	 false��   �� *
IsEditable+! �� "" ��	 false.0��� $ templateRoot��8   � ���� $ templateRoot��8   � ��^�  ��   �� *	IsEnabled+! �� *Self+	 false��   �� *
IsEditable+! �� "" �� true.0��� $ templateRoot��8   � ���� $ templateRoot��8   � ���� $ splitBorder��8   � ���� $ splitBorder��8   � ���� " ��.R�� $# templateRoot��	 . $ �� $��* ��� #��� r�$��0 �.+�� $% 
PART_Popup��& . $��2��$��1q�#��� .�$��Bottom=����� *IsDropDownOpen+$' TwoWay=�! �� *TemplatedParent+.��  $( shadow��$) Transparent��#��z* ���� *ActualWidth+$+ templateRoot��._��� $ dropDownBorder��$ 5��#��� ��$��1q�#��� ��._��� $ DropDownScrollViewer��.��� $
# grid��$, Enabled=�.+��� $- canvas��$
��Left=�$��0��$	��Top=�$��0��.+��� $. 
opaqueRect��$/ 5��$0 5������ *
Background+$+ dropDownBorder������ *ActualHeight+$+ dropDownBorder������ *ActualWidth+$+ dropDownBorder���� $1 ItemsPresenter��$2 	Contained=�#	 z	 d� $3 toggleButton��#��z��#��z��#��z��$��2��8��  4 �� *IsDropDownOpen+$' TwoWay=�! �� *TemplatedParent+�� $ contentPresenter��#��z5 #��z��#��z6 #8 z7 #��z��9 .  #��z��#	 z	 #��z�� P� $: 
PART_Popup�� �@�HasDropShadow . . ��� $ shadow�� � ��$ 0,0,5,5q��� $ shadow�� �@ Color$ 	#71000000��P�  �@��HasItems .  . ��� $ dropDownBorder�� � ��$ 95��]�  ��  �@��
IsGrouping . �� " �@%�IsVirtualizingWhenGrouping .  ./���  � �� .  P� $: DropDownScrollViewer�� � �� .  . ��� $ 
opaqueRect�� �� *VerticalOffset+$+ DropDownScrollViewer�� �@��Top�� $ 
opaqueRect�� �� *HorizontalOffset+$+ DropDownScrollViewer�� �@��Left�� $ 	#FFFFFFFF���� " ��.���  �@�OverridesDefaultStyle . ��  �@J�	AllowDrop . ��  � ��$ 0����  � ��$ 0����  �@�FocusVisualStyle Z� ��  �@��PanningMode$ VerticalFirst=���  �@��IsFlicksEnabled .  ��  � �� �� " ��.R��� $ PART_ContentHost��
������ |�.  $��Hidden=�$��Hidden=��� " ��.R�� $# templateRoot��	 . $ �� $��* ��� #��� r�$��0 �.+�� $% 
PART_Popup��& . $��2��#��� .�$��Bottom=����� *IsDropDownOpen+! �� *TemplatedParent+.��  $( shadow��$) Transparent��#��z* ���� *ActualWidth+$+ templateRoot��._��� $ dropDownBorder��#��� ��$��1q�#��� ��._��� $ DropDownScrollViewer��.��� $
# grid��$, Enabled=�.+��� $- canvas��$
��Left=�$��0��$	��Top=�$��0��.+��� $. 
opaqueRect������ *
Background+$+ dropDownBorder������ *ActualHeight+$+ dropDownBorder������ *ActualWidth+$+ dropDownBorder���� $1 ItemsPresenter��$2 	Contained=�#	 z	 d� $3 toggleButton��#��z��#��z��#��z��$��2��8��  4 �� *IsDropDownOpen+$' TwoWay=�! �� *TemplatedParent+�� $ border��8�� #��z��._��� $; PART_EditableTextBox��#��z��#��z��8�� #��z��< �� *
IsReadOnly+! �� *TemplatedParent+ P�  � {� .  . ��� $ border�� �@J�Opacity$
 0.56Q�P�  �@J�IsKeyboardFocusWithin . . ���  � ��
 �   �P� $: 
PART_Popup�� �@�HasDropShadow . . ��� $ shadow�� � ��$ 0,0,5,5q��� $ shadow�� �@ Color$ 	#71000000��P�  �@��HasItems .  . ��� $ dropDownBorder�� � ��$ 95��]�  ��  �@��
IsGrouping . �� " �@%�IsVirtualizingWhenGrouping .  ./���  � �� .  P� $: DropDownScrollViewer�� � �� .  . ��� $ 
opaqueRect�� �� *VerticalOffset+$+ DropDownScrollViewer�� �@��Top�� $ 
opaqueRect�� �� *HorizontalOffset+$+ DropDownScrollViewer�� �@��Left�� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$
 Auto=���  � ��$
 Auto=���  � ��$ 6,3,5,3q���  � �� . ��  �@��PanningMode$
 Both=���  �@��IsFlicksEnabled .  ��  � ��8   P�  �@��
IsEditable . . ���  � �� .  ��  � ��$ 2q���  � ��8  �� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $ border��$ 10��#��z��#��z��#��z��	 . ._��� $ contentPresenter��|�.  #��z��#��z����. #	 z	 #��z�� P�  �@��IsDefaulted . . ��� $ border��# � �� � ��P�  �@J�IsMouseOver . . ��� $ border��8   � ���� $ border��8   � ��P�  � �� . . ��� $ border��8   � ���� $ border��8   � ��P�  � {� .  . ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8 	  � ���� $ 	#FFFFFFFF���� $ 	#FFABADB3���� $ 	#FFFFFFFF���� $ 	#FFD9D9D9���� " ��.���  � ��8   ��  � ��8  ��  � ��$ 1q���  � ��# � ����  � ��$
 Auto=���  � ��$
 Auto=���  � �� . ��  �@��PanningMode$
 Both=���  �@��IsFlicksEnabled .  ��  � ��$ Center=���  � �� �� " ��.R��� $ Bd��$ 20�����	#FFE6E6E6$��5q�#��z��$= 1q�	 . ._��� |�.  #��z��.���� #	 z	  P�  � {� .  . ��� $ Bd��8   � ���� $ Bd��8   � ��]�  ��  �@��
IsGrouping . �� " �@%�IsVirtualizingWhenGrouping .  ./���  � �� .  .��� -   .+��� $/ 20��$0 20�����	#FFF4F4F5$	��737��
�������$��1��$
��1300��$��0,5,0,8q��� -   > ��Name$
> Exit��$
��Exit��$
��Left=�$��1260,20,0,0q�$	��Top=�$��25��$��25��#��� 
 ��Z� ��Z� ���� ? �� ImageSource$,? &/TradeLog;component/Resource/close.png��@ j� Stretch$@ Uniform=��� -   $> 	minimized��$��	minimized��$
��Left=�$��1221,19,0,0q�$	��Top=�$��27��$��27��#��� 
 ��Z� ��Z� ���� $/? )/TradeLog;component/Resource/minimize.png��$@ Uniform=��� -   $
> Back��$
��Back��$
��Left=�$��1182,19,0,0q�$	��Top=�$��27��$��27��#��� 
 ��Z� ��Z� ���� $+? %/TradeLog;component/Resource/back.png��$@ Uniform=��� ���	#FFBFBFBF$
��Left=�$��1��$��
40,702,0,0q�$0 0��$/ 0�����	#FFC3C3C3$	��Top=�$
��1220���� ���	#FFBFBFBF$
��Left=�$��1��$��
40,474,0,0q�$0 0��$/ 0�����	#FFC3C3C3$	��Top=�$
��1220���� ���	#FFBFBFBF$
��Left=�$��1��$��
40,258,0,0q�$0 0��$/ 0�����	#FFC3C3C3$	��Top=�$
��1220��A� -   A A�Name$	A sql��
������ $
��Left=�$��10��$��
55,716,0,0q�
���   �$	��0.1��$	��Top=�$��10��A� -   $	A xml��
������ $
��Left=�$��10��$��
74,716,0,0q�
���   �$	��0.1��$	��Top=�$��10���� $��Felhasználó��$
��Left=�$��14(�$��Bahnschrift Light)�$��	26,26,0,0q�$	��Top=��� -   $; 	teljesNev��$��0q�$
��Left=�$��23��$��	41,55,0,0q�B �� TextWrapping$
B Wrap=�$	��Top=�$	��180��#���  C �� TextAlignment$C Center=�$��Center=�$��Center=�$��Bahnschrift Light)��� $��Azonosító��$
��Left=�$��14(�$��Bahnschrift Light)�$��	26,78,0,0q�$	��Top=��� -   $; 	azonosito��$��0q�$
��Left=�$��23��$��
41,105,0,0q�$
B Wrap=�$	��Top=�$	��100��#���  $C Center=�$��Center=�$��Center=�$��Bahnschrift Light)��� $��Aktuális Tőke��$
��Left=�$��14(�$��Bahnschrift Light)�$��
26,133,0,0q�$	��Top=��� -	   $; aktualistoke��$��0q�$
��Left=�$��23��$��
41,159,0,0q�$
B Wrap=�$	��Top=�$	��100��#���  $��Center=�$��Center=�$C Right=�$��Bahnschrift Light)��� -
   D ��Name$D eurText��$	��EUR��$
��Left=�$��140,156,0,0q�$	��Top=�$y�Hidden=��� ���	#FFE6E6E6$
��Left=�$	��220��$��
287,25,0,0q�$0 20��$/ 20��
������ $	��Top=�$	��273���� $��Találati arány :��$
��Left=�$��14(�$��Bahnschrift Light)�$��
298,37,0,0q�$	��Top=�$��29��$	��102���� $��Kereskedések száma:��$
��Left=�$��14(�$��Bahnschrift Light)�$��
298,69,0,0q�$	��Top=�$��29��$	��147���� $��Össz. nyereség:��$
��Left=�$��14(�$��Bahnschrift Light)�$��298,101,0,0q�$	��Top=�$��29��$	��107���� $��PayOff ration:��$
��Left=�$��14(�$��Bahnschrift Light)�$��298,135,0,0q�$	��Top=�$��29��$��95���� $��Célár megvalósulás:��$
��Left=�$��14(�$��Bahnschrift Light)�$��298,166,0,0q�$	��Top=�$��29��$	��137���� $��Pozíció építés:��$
��Left=�$��14(�$��Bahnschrift Light)�$��298,199,0,0q�$	��Top=�$	��102���� -   $; talalatiAranyTB��$��Center=�$��Center=�$
��Left=�$��23��$��
400,40,0,0q�$
B Wrap=�$��0q�$	��Top=�$	��137��
�������#���  $��Bahnschrift Light)��� -   $; kereskedesekSzamaTB��$��Center=�$��Center=�$
��Left=�$��23��$��
445,72,0,0q�$
B Wrap=�$��0q�$	��Top=�$��92��
�������#���  $��Bahnschrift Light)��� -   $; osszNyeresegTB��$��Center=�$��Center=�$
��Left=�$��23��$��405,105,0,0q�$
B Wrap=�$��0q�$	��Top=�$	��132��
�������#���  $��Bahnschrift Light)��� -   $; payoffrationTB��$��Center=�$��Center=�$
��Left=�$��23��$��392,138,0,0q�$
B Wrap=�$��0q�$	��Top=�$	��145��
�������#���  $��Bahnschrift Light)��� -   $; celarmegvalosultTB��$��Center=�$��Center=�$
��Left=�$��23��$��435,169,0,0q�$
B Wrap=�$��0q�$	��Top=�$	��102��
�������#���  $��Bahnschrift Light)��� -   $; pozicioepitesTB��$��Center=�$��Center=�$
��Left=�$��23��$��395,201,0,0q�$
B Wrap=�$��0q�$	��Top=�$	��142��
�������#���  $��Bahnschrift Light)��� $��Új Ticket jegyzés:��$
��Left=�$��14(�$��Bahnschrift Light)�$��
39,263,0,0q�$	��Top=��� $
��Left=�$	��103��$��
55,298,0,0q�$0 10��$/ 10��
�������$��0��$	��Top=�$
��1193�����	#FFE6E6E6�� $��Ticket��$
��Left=�$��
82,315,0,0q�$	��Top=�$��59��$��Bahnschrift Light)��� $��
Devizapár��$
��Left=�$��163,315,0,0q�$	��Top=�$��71��$��Bahnschrift Light)��� $��
Mennyiség��$
��Left=�$��256,315,0,0q�$	��Top=�$��71��$��Bahnschrift Light)��� $��Idősík��$
��Left=�$��345,315,0,0q�$	��Top=�$��46��$��Bahnschrift Light)��� $��Price (Nyit)��$
��Left=�$��408,315,0,0q�$	��Top=�$��70��$��Bahnschrift Light)��� $��
S/L (Stop)��$
��Left=�$��491,315,0,0q�$	��Top=�$��70��$��Bahnschrift Light)��� $��T/P (Célár)��$
��Left=�$��578,315,0,0q�$	��Top=�$��70��$��Bahnschrift Light)��� $��Price (Zár)��$
��Left=�$��672,315,0,0q�$	��Top=�$��73��$��Bahnschrift Light)��� $+��%Profit / Veszteség / Építés (+/-)��$
��Left=�$��755,315,0,0q�$	��Top=�$	��180��$��26��$��Bahnschrift Light)��� $��Kép (Csatolás)��$
��Left=�$��942,315,0,0q�$	��Top=�$��88��$��26��$��Bahnschrift Light)��� $+��%Megjegyzés / Mentális jegyzőkönyv��$
��Left=�$��1045,315,0,0q�$	��Top=�$	��198��$��26��$��Bahnschrift Light)��� -   $; ticketTB��$
��Left=�$��23��$��
71,344,0,0q�$B NoWrap=�$	��Top=�$��67��$��Center=�$��Center=�#���  �� -   $; devizaparTB��$
��Left=�$��23��$��160,344,0,0q�$B NoWrap=�$	��Top=�$C Center=�$��67��$��Center=�$��Center=�#���  �� -   $; mennyisegTB��$
��Left=�$��23��$��256,344,0,0q�$B NoWrap=�$	��Top=�$��67��$��Center=�$��Center=�#���  �� -   $; nyitoTB��$
��Left=�$��23��$��409,344,0,0q�$B NoWrap=�$	��Top=�$��67��$��Center=�$��Center=�#���  �� -   $; stopTB��$
��Left=�$��23��$��492,344,0,0q�$B NoWrap=�$	��Top=�$��67��$��Center=�$��Center=�#���  �� -   $; celarTB��$
��Left=�$��23��$��578,344,0,0q�$B NoWrap=�$	��Top=�$��70��$��Center=�$��Center=�#���  �� -   $; zarTB��$
��Left=�$��23��$��670,344,0,0q�$B NoWrap=�$	��Top=�$��72��$��Center=�$��Center=�#���  �� -   $; osszegTB��$
��Left=�$��23��$��783,344,0,0q�$B NoWrap=�$	��Top=�$	��117��$��Center=�$��Center=�#���  �� -   E ��Name$E idosikCB��$
��Left=�$��332,344,0,0q�$	��Top=�$��68��#��� 1 �� -   $��Button��$
��Left=�$��35��$��961,341,0,0q�$	��Top=�$��50����Z� ��Z� ���� $-? '/TradeLog;component/Resource/attach.png��$@ Uniform=��� -   $; megjegyzesTB��$
��Left=�$��23��$��1075,341,0,0q�$
B Wrap=�$	��Top=�$	��120��$��Center=�$��Center=��� -   $> 
jegyzesBtn��$��5q�$��Jegyzés��$
��Left=�$��1171,420,0,0q�$	��Top=�$��75��
����������	#FFE6E6E6
���   �$��Bahnschrift Light)�$��14(�#��� 2 $��35���� ���	#FFE6E6E6$
��Left=�$��25��$��1205,397,0,0q�
�������$��0��$	��Top=�$��6���� -   F ��Name$	F lb1��$
��Left=�$	��190��$��
55,495,0,0q�$	��Top=�$
��1188��#��� 7 $��Bahnschrift Light)�